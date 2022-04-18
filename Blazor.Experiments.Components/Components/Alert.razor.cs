namespace Blazor.Experiments.Components;

public partial class Alert
{
    protected string ClassName => new CssBuilder().AddClass("alert")
                                                  .AddClass($"alert-{Color.ToDescriptionString()}")
                                                  .AddClass("alert-dismissible", Closable)
                                                  .AddClass("alert-important", Important)
                                                  .AddClass(Class)
                                                  .ToString();

    [Parameter]
    public Color Color { get; set; }

    [Parameter]
    public bool NoIcon { get; set; }

    [Parameter]
    public string Icon { get; set; }

    [Parameter]
    public bool Important { get; set; }

    [Parameter]
    public bool Closable { get; set; }

    [Parameter]
    public string Title { get; set; }
    
    [Parameter]
    public string Message { get; set; }

    [Parameter]
    public RenderFragment MessageContent { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }
}
