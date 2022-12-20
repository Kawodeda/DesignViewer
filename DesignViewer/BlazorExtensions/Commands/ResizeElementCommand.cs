using BlazorExtensions.Commands.Context;
using BlazorExtensions.Commands.Parameters;
using Model.Design.Math;

namespace BlazorExtensions.Commands
{
    public class ResizeElementCommand : ICommand
    {
        private ResizeElementCommandParams _params;

        public ResizeElementCommand(ResizeElementCommandParams @params) 
        {
            _params = @params;
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Execute(IExecutionContext context)
        {
            Affine2DMatrix transform = _params.Element.Transform;
            _params.Element.Transform = (transform.TranslationMatrix * transform.RotationMatrix)
                .Scale(_params.ScaleX, _params.ScaleY);
        }
    }
}
