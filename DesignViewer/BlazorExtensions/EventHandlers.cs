using Microsoft.AspNetCore.Components;

namespace BlazorExtensions
{
    [EventHandler("onanimationend", typeof(EventArgs), enableStopPropagation: true, enablePreventDefault: false)]
    public class EventHandlers
    {

    }
}
