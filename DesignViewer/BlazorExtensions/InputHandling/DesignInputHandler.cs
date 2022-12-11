using Model.Design;
using Model.Design.Content.Controls;
using Model.Design.Math;
using BlazorExtensions.Commands;
using BlazorExtensions.Commands.Parameters;
using Microsoft.AspNetCore.Components.Web;
using System.Xml.Linq;
using System.Threading;

namespace BlazorExtensions.InputHandling
{
    public enum DesignState
    {
        Default = 0,
        Translate = 1,
        ElementPlacing = 2
    }

    public enum MouseButton
    {
        Left = 0,
        Middle = 1,
        Right = 2
    }

    public class DesignInputHandler : InputHandlerBase
    {
        private const string AddElementKeyCode = "KeyA";        

        private IDesignViewer _designViewer;
        private DesignState _state;
        private IElementCreator _elementCreator = new ElementCreator();
        private float _prevMouseX;
        private float _prevMouseY;
        private Element? _capturedElement;

        public DesignInputHandler(IDesignViewer designViewer)
        {
            _designViewer = designViewer;
            _state = DesignState.Default;
        }

        public override ICommand OnMouseDown(MouseEventArgs e)
        {
            var mouse = new Point((float)e.OffsetX, (float)e.OffsetY);

            if (_state == DesignState.ElementPlacing)
            {
                return HandleElementPlacing(mouse);
            }

            Element? element = _designViewer.CurrentSurface.Layers
                    .SelectMany(x => x.Elements)
                    .Reverse()
                    .FirstOrDefault(x => IsWithinElement(x, mouse));

            if (element != _designViewer.SelectedElement)
            {
                _capturedElement = element;
            }

            if (_designViewer.SelectedElement == null)
            {
                return base.OnMouseDown(e);
            }
            if (!IsWithinElement(_designViewer.SelectedElement, mouse) 
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
                        return base.OnMouseMove(e);
                    }

                    var transform = _designViewer.Transform;
                    transform.D1 = 0f;
                    transform.D2 = 0f;

                    var elementTransform = _designViewer.SelectedElement.Transform;

                    var shift = new Point(
                        mouse.X - _prevMouseX,
                        mouse.Y - _prevMouseY)
                        * transform.Inverse()
                        * elementTransform;

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

        private ICommand HandleElementPlacing(Point mouse)
        {
            _state = DesignState.Default;
            Element element = _elementCreator.CreateRandomRectangle();
            element.Position = ViewportToSurface(mouse, element) - element.Center;
            _capturedElement = element;
            StartTranslate(mouse);

            return new CompositeCommand(
                new AddElementCommand(element),
                new ChangeSelectionCommand(element));
        }

        private void StartTranslate(Point mouse)
        {
            _state = DesignState.Translate;
            _prevMouseX = mouse.X;
            _prevMouseY = mouse.Y;
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
