using BlazorExtensions.Commands.Context;
using BlazorExtensions.Models;
using Model.Design;
using Model.Design.Content;
using Model.Design.Math;

namespace BlazorExtensions.Commands
{
    public class SetMockupCommand : ICommand
    {
        private Asset _mockupAsset;

        public SetMockupCommand(Asset asset)
        {
            _mockupAsset = asset;
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Execute(IExecutionContext context)
        {
            Point artboardCenter = (Point)context.DesignViewer.CurrentSurface.Artboards.First().ActualSize * 0.5f;
            var mockup = new Mockup()
            {
                Position = artboardCenter,
                Transform = Affine2DMatrix.CreateScale(0.6f),
                Content = new Image()
                {
                    StorageId = _mockupAsset.Info.StorageId
                }
            };

            context.DesignViewer.CurrentSurface.Mockup = mockup;
        }
    }
}
