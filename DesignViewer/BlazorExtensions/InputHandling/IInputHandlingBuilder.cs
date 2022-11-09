namespace BlazorExtensions.InputHandling
{
    public interface IInputHandlingBuilder : IInputHandler
    {
        public void UseHandler<T>() where T : InputHandlerBase;
    }
}
