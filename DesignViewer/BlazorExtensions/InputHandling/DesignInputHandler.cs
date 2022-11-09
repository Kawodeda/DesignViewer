using Aurigma.Design;
using Aurigma.Design.Content.Controls;
using Aurigma.Design.Math;
using BlazorExtensions.Commands;
using BlazorExtensions.Commands.Parameters;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorExtensions.InputHandling
{
    public enum DesignState
    {
        Default = 0,
        Translate = 1,
        ElementPlacing = 2
    }

    public class DesignInputHandler : InputHandlerBase
    {
        private const string AddElementKeyCode = "KeyA";        

        private IDesignViewer _designViewer;
        private DesignState _state;
        private IElementCreator _elementCreator = new ElementCreator();
        private float _prevMouseX;
        private float _prevMouseY;

        public DesignInputHandler(IDesignViewer designViewer)
        {
            _designViewer = designViewer;
            _state = DesignState.Default;
        }

        public override ICommand OnClick(MouseEventArgs e)
        {
            if (e.Button == 0)
            {
                float mouseX = (float)e.OffsetX;
                float mouseY = (float)e.OffsetY;
                var mouse = new Point(mouseX, mouseY);

                Element? element = _designViewer.CurrentSurface.Layers
                    .SelectMany(x => x.Elements)
                    .FirstOrDefault(x => IsWithinElement(x, mouse));

                if (element != _designViewer.SelectedElement)
                {
                    return new ChangeSelectionCommand(element);
                }
            }

            return base.OnClick(e);
        }

        public override ICommand OnMouseDown(MouseEventArgs e)
        {
            float mouseX = (float)e.OffsetX;
            float mouseY = (float)e.OffsetY;
            var mouse = new Point(mouseX, mouseY);

            if (_state == DesignState.ElementPlacing)
            {
                _state = DesignState.Default;
                Element element = _elementCreator.CreateRandomRectangle();
                element.Position = ViewportToSurface(mouse, element);
                return new AddElementCommand(element);
            }
            if (_designViewer.SelectedElement == null)
            {
                return base.OnMouseDown(e);
            }
            if (IsWithinElement(_designViewer.SelectedElement, mouse)
                == false)
            {
                return base.OnMouseDown(e);
            }

            _state = DesignState.Translate;
            _prevMouseX = mouseX;
            _prevMouseY = mouseY;

            return new EmptyCommand();
        }

        public override ICommand OnMouseMove(MouseEventArgs e)
        {
            switch (_state)
            {
                case DesignState.Translate:
                    if(_designViewer.SelectedElement == null)
                    {
                        return base.OnMouseMove(e);
                    }

                    float mouseX = (float)e.OffsetX;
                    float mouseY = (float)e.OffsetY;

                    var transform = _designViewer.Transform;
                    transform.D1 = 0f;
                    transform.D2 = 0f;

                    var elementTransform = _designViewer.SelectedElement.Transform;
                    elementTransform.D1 = 0f;
                    elementTransform.D2 = 0f;

                    var shift = new Point(
                        mouseX - _prevMouseX, 
                        mouseY - _prevMouseY)
                        * transform.Inverse()
                        * elementTransform;

                    _prevMouseX = mouseX;
                    _prevMouseY = mouseY;

                    return new TranslateElementCommand(
                        new TranslateElementCommandParams(
                            _designViewer.SelectedElement,
                            shift));

                default:
                    return base.OnMouseMove(e);
            }
        }

        public override ICommand OnMouseUp(MouseEventArgs e)
        {
            _state = DesignState.Default;

            return base.OnMouseUp(e);
        }

        public override ICommand OnKeyPress(KeyboardEventArgs e)
        {
            if (_state != DesignState.Default)
            {
                return base.OnKeyPress(e);
            }
            if (e.Code != AddElementKeyCode)
            {
                return base.OnKeyPress(e);
            }

            _state = DesignState.ElementPlacing;

            return new EmptyCommand();
        }

        public override ICommand OnKeyDown(KeyboardEventArgs e)
        {
            if (e.Code == "Delete")
            {
                if (_designViewer.SelectedElement != null)
                {
                    return new CompositeCommand(
                        new DeleteElementCommand(_designViewer.SelectedElement),
                        new ChangeSelectionCommand(null));
                }
            }

            return base.OnKeyDown(e);
        }

        private bool IsWithinElement(Element element, Point point)
        {
            RectangleControls rectangle 
                = element.Content.ClosedVector.Controls.Rectangle;
            Affine2DMatrix transform = _designViewer.Transform;
            Point elementPos = element.Position;
            Point corner1 = elementPos + rectangle.Corner1;
            Point corner2 = elementPos + rectangle.Corner2;
            point *= element.Transform * transform.Inverse();               

            return point.X > corner1.X
                && point.X < corner2.X
                && point.Y > corner1.Y
                && point.Y < corner2.Y;
        }

        private Point ViewportToSurface(Point inViewport, Element element)
        {
            var transform = _designViewer.Transform;

            var elementTransform = element.Transform;
            elementTransform.D1 = 0f;
            elementTransform.D2 = 0f;

            return inViewport 
                * transform.Inverse() 
                * elementTransform;
        }
    }
}
