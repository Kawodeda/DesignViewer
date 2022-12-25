using Model.Design;
using Model.Design.Math;
using BlazorExtensions.Commands;
using BlazorExtensions.Commands.Parameters;
using Microsoft.AspNetCore.Components.Web;
using BlazorExtensions.Services;
using BlazorExtensions.Viewports;

namespace BlazorExtensions.InputHandling
{
    public enum DesignState
    {
        Default = 0,
        Translate = 1
    }

    public enum MouseButton
    {
        Left = 0,
        Middle = 1,
        Right = 2
    }

    public class DesignInputHandler : BaseInputHandler
    {
        private const string AddElementKeyCode = "KeyA";        

        private IDesignViewer _designViewer;
        private DesignState _state;
        private IElementFactory _elementCreator = new ElementFactory();
        private float _prevMouseX;
        private float _prevMouseY;
        private Element? _capturedElement;

        public DesignInputHandler(IDesignViewer designViewer)
        {
            _designViewer = designViewer;
            _state = DesignState.Default;
            _designViewer.SelectedElementChanged += OnSelectedElementChanged;
            _designViewer.Viewport.ZoomChanged += OnViewportZoomChanged;
            _designViewer.Viewport.ScrollChanged += OnViewportScrollChanged;
        }

        public override ICommand OnMouseDown(MouseEventArgs e)
        {
            var mouse = new Point((float)e.OffsetX, (float)e.OffsetY);

            Element? element = _designViewer.CurrentSurface.Layers
                    .SelectMany(x => x.Elements)
                    .Reverse()
                    .FirstOrDefault(x => HitTest(x, mouse));

            if (element != _designViewer.SelectedElement)
            {
                _capturedElement = element;
            }

            if (_designViewer.SelectedElement == null)
            {
                return base.OnMouseDown(e);
            }
            if (!HitTest(_designViewer.SelectedElement, mouse)
                || _capturedElement != _designViewer.SelectedElement)
            {
                return base.OnMouseDown(e);
            }

            StartTranslate(mouse);

            return new EmptyCommand();
        }

        public override ICommand OnMouseMove(MouseEventArgs e)
        {
            var mouse = new Point((float)e.OffsetX, (float)e.OffsetY);

            switch (_state)
            {
                case DesignState.Translate:
                    if(_designViewer.SelectedElement == null)
                    {
                        _state = DesignState.Default;
                        return base.OnMouseMove(e);
                    }

                    var shift = ViewportToSurface(
                        new Point(mouse.X - _prevMouseX, mouse.Y - _prevMouseY),
                        _designViewer.SelectedElement,
                        RemoveTranslate(_designViewer.Transform));

                    _prevMouseX = mouse.X;
                    _prevMouseY = mouse.Y;

                    return new TranslateElementCommand(
                        new TranslateElementCommandParams(
                            _designViewer.SelectedElement,
                            shift));

                case DesignState.Default:
                    if(_capturedElement == null 
                        || _capturedElement == _designViewer.SelectedElement)
                    {
                        return base.OnMouseMove(e);
                    }

                    StartTranslate(mouse);

                    return new ChangeSelectionCommand(_capturedElement);

                default:
                    return base.OnMouseMove(e);
            }
        }

        public override ICommand OnMouseUp(MouseEventArgs e)
        {
            if(_state != DesignState.Default)
            {
                _state = DesignState.Default;

                return base.OnMouseUp(e);
            }

            return new ChangeSelectionCommand(_capturedElement);
        }

        public override ICommand OnKeyDown(KeyboardEventArgs e)
        {
            if (e.Code == "Delete")
            {
                if (_designViewer.SelectedElement != null)
                {
                    _capturedElement = null;
                    return new CompositeCommand(
                        new DeleteElementCommand(_designViewer.SelectedElement),
                        new ChangeSelectionCommand(null));
                }
            }

            return base.OnKeyDown(e);
        }

        private void OnSelectedElementChanged(object? sender, Element? element)
        {
            _capturedElement = element;
        }

        private void OnViewportZoomChanged(object? sender, ZoomChangedEventArgs args)
        {
            if (_state != DesignState.Translate || _designViewer.SelectedElement == null)
            {
                return;
            }

            _designViewer.ExecuteCommand(new ChangeSelectionCommand(null));   
        }

        private void OnViewportScrollChanged(object? sender, ScrollChangedEventArgs args)
        {
            if (_state != DesignState.Translate || _designViewer.SelectedElement == null)
            {
                return;
            }

            var shift = ViewportToSurface(
                new Point(-args.DeltaScrollX, -args.DeltaScrollY), 
                _designViewer.SelectedElement,
                RemoveTranslate(_designViewer.Transform));

            _designViewer.ExecuteCommand(new TranslateElementCommand(
                        new TranslateElementCommandParams(
                            _designViewer.SelectedElement,
                            shift)));
        }

        private void StartTranslate(Point mouse)
        {
            _state = DesignState.Translate;
            _prevMouseX = mouse.X;
            _prevMouseY = mouse.Y;
        }

        private bool HitTest(Element element, Point point)
        {
            return _designViewer.HitTestStrategyFactory
                .Create(element)
                .HitTest(point, _designViewer.Transform);
        }

        private Point ViewportToSurface(Point inViewport, Element element, Affine2DMatrix viweportTransform)
        { 
            return inViewport 
                * viweportTransform.Inverse() 
                * element.Transform.RotationMatrix;
        }

        private Affine2DMatrix RemoveTranslate(Affine2DMatrix transform)
        {
            Affine2DMatrix result = transform.Clone();
            result.D1 = 0;
            result.D2 = 0;

            return result;
        }
    }
}
