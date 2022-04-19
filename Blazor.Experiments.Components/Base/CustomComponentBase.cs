namespace Blazor.Experiments.Components.Base;

public abstract class CustomComponentBase : ComponentBase
{
    [Parameter]
    public string Class { get; set; }

    [Parameter]
    public string Style { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> UserAttributes { get; set; } = new Dictionary<string, object>();
}
