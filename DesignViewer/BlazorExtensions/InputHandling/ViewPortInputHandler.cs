using BlazorExtensions.Commands;
using BlazorExtensions.Commands.Parameters;
using BlazorExtensions.Viewports;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorExtensions.InputHandling
{
    public enum ViewPortState
    {
        Default = 0,
        ScrollX = 1,
        ScrollY = 2
    }

    public class ViewPortInputHandler : InputHandlerBase
    {
        private IViewport _viewPort;
        private ViewPortState _state;
        private float _prevMouseX;
        private float _prevMouseY;
        private bool _blockOnClick;

        public ViewPortInputHandler(IViewport viewPort)
        {
            _viewPort = viewPort;
            _state = ViewPortState.Default;
        }

        // Saves from IInputHandlingBuilder failure when it tries
        // to create an instance of ViewPortInputHandler
        public ViewPortInputHandler(IDesignViewer viewer)
            : this(viewer.Viewport) { }

        public override ICommand OnClick(MouseEventArgs e)
        {
            if(_blockOnClick)
            {
                _blockOnClick = false;
                return new EmptyCommand();
            }

            return HandleByDefault(() => Next?.OnClick(e));
        }

        public override ICommand OnMouseDown(MouseEventArgs e)
        {
            ICommand result = new EmptyCommand();
            float mouseX = (float)e.OffsetX;
            float mouseY = (float)e.OffsetY;

            // To Do: implement individual handlers to handle scrollbars
            ICommand? horResult = HandleHorizontalScrollbarMouseDown(e);
            if (horResult != null)
            {
                return horResult;
            }

            ICommand? vertResult = HandleVerticalScrollbarMouseDown(e);
            if (vertResult != null)
            {
                return vertResult;
            }

            ICommand? nextResult = Next?.OnMouseDown(e);
            if (nextResult != null)
            {
                result = nextResult;
            }

            return result;
        }

        public override ICommand OnMouseMove(MouseEventArgs e)
        {
            ICommand result = new EmptyCommand();

            switch (_state)
            {
                case ViewPortState.ScrollX:
                    float dx = (float)(e.OffsetX - _prevMouseX);
                    float dScrollX = GetScrollXFromScrollbarShift(dx);
                    result = new ScrollCommand(
                        new ScrollCommandParams(dScrollX, 0f));
                    break;

                case ViewPortState.ScrollY:
                    float dy = (float)(e.OffsetY - _prevMouseY);
                    float dScrollY = GetScrollYFromScrollbarShift(dy);
                    result = new ScrollCommand(
                        new ScrollCommandParams(0f, dScrollY));
                    break;

                default:
                    ICommand? nextResult = Next?.OnMouseMove(e);
                    if (nextResult != null)
                    {
                        result = nextResult;
                    }
                    break;
            }

            _prevMouseX = (float)e.OffsetX;
            _prevMouseY = (float)e.OffsetY;

            return result;
        }

        public override ICommand OnMouseOut(MouseEventArgs e)
        {
            _state = ViewPortState.Default;

            return HandleByDefault(() => Next?.OnMouseOut(e));
        }

        public override ICommand OnMouseUp(MouseEventArgs e)
        {
            if (_state != ViewPortState.Default)
            {
                _blockOnClick = true;
            }

            _state = ViewPortState.Default;

            return HandleByDefault(() => Next?.OnMouseUp(e));
        }

        public override ICommand OnWheel(WheelEventArgs e)
        {
            const float zoomFactor = -0.0008f;
            const float scrollFactor = -0.08f;

            if (e.ShiftKey)
            {
                float deltaZoom = (float)e.DeltaY * zoomFactor;
                return new ZoomCommand(
                    new ZoomCommandParams(deltaZoom));
            }

            float yShift = (float)e.DeltaY * scrollFactor;
            return new ScrollCommand(
                new ScrollCommandParams(0f, yShift));
        }

        private ICommand? HandleHorizontalScrollbarMouseDown(MouseEventArgs e)
        {
            ICommand? result = null;
            float mouseX = (float)e.OffsetX;
            float mouseY = (float)e.OffsetY;

            if (e.Button == 0)
            {
                if (_viewPort.IsHorizontalScrollbarShown
                    && IsWithinHorizontalScrollbar(mouseX, mouseY))
                {
                    _state = ViewPortState.ScrollX;
                    _prevMouseX = mouseX;

                    if (IsWithinHorizontalScrollbarBody(mouseX, mouseY) == false)
                    {
                        float dx = mouseX - _viewPort.HorizontalScrollbarBodyPos;
                        float dScrollX = GetScrollXFromScrollbarShift(dx);

                        result = new ScrollCommand(
                            new ScrollCommandParams(dScrollX, 0f));

                        return result;
                    }

                    return new EmptyCommand();
                }
            }

            return result;
        }

        private ICommand? HandleVerticalScrollbarMouseDown(MouseEventArgs e)
        {
            ICommand? result = null;
            float mouseX = (float)e.OffsetX;
            float mouseY = (float)e.OffsetY;

            if (e.Button == 0)
            {
                if (_viewPort.IsVerticalScrollbarShown
                    && IsWithinVerticalScrollbar(mouseX, mouseY))
                {
                    _state = ViewPortState.ScrollY;
                    _prevMouseY = mouseY;

                    if (IsWithinVerticalScrollbarBody(mouseX, mouseY) == false)
                    {
                        float dy = mouseY - _viewPort.VerticalScrollbarBodyPos;
                        float dScrollY = GetScrollYFromScrollbarShift(dy);

                        result = new ScrollCommand(
                            new ScrollCommandParams(0f, dScrollY));

                        return result;
                    }

                    return new EmptyCommand();
                }
            }

            return result;
        }

        private float GetScrollXFromScrollbarShift(float shift)
        {
            return _viewPort.ScrollableAreaSize.Width * -shift
                / _viewPort.HorizontalScrollbarWidth;
        }

        private float GetScrollYFromScrollbarShift(float shift)
        {
            return _viewPort.ScrollableAreaSize.Height * -shift
                / _viewPort.VerticalScrollbarHeight;
        }

        private bool IsWithinHorizontalScrollbar(float x, float y)
        {
            return x >= 0
                && x <= _viewPort.Size.Width - _viewPort.ScrollbarSize
                && y > _viewPort.Size.Height - _viewPort.ScrollbarSize
                && y < _viewPort.Size.Height;
        }

        private bool IsWithinVerticalScrollbar(float x, float y)
        {
            return x >= _viewPort.Size.Width - _viewPort.ScrollbarSize
                && x <= _viewPort.Size.Width
                && y > 0
                && y < _viewPort.Size.Height - _viewPort.ScrollbarSize;
        }

        private bool IsWithinHorizontalScrollbarBody(float x, float y)
        {
            return x >= _viewPort.HorizontalScrollbarBodyPos
                && x <= _viewPort.HorizontalScrollbarBodyPos + _viewPort.HorizontalScrollbarBodyWidth
                && y > _viewPort.Size.Height - _viewPort.ScrollbarSize
                && y < _viewPort.Size.Height;
        }

        private bool IsWithinVerticalScrollbarBody(float x, float y)
        {
            return x >= _viewPort.Size.Width - _viewPort.ScrollbarSize
                && x <= _viewPort.Size.Width
                && y > _viewPort.VerticalScrollbarBodyPos
                && y < _viewPort.VerticalScrollbarBodyPos + _viewPort.VerticalScrollbarBodyHeight;
        }
    }
}
