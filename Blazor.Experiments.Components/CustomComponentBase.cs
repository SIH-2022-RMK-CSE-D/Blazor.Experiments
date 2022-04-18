namespace Blazor.Experiments.Components;

public abstract class CustomComponentBase : ComponentBase
{
    [Parameter]
    public string Class { get; set; }

    [Parameter]
    public string Style { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }
}
