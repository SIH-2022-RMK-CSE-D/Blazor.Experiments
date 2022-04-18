namespace Blazor.Experiments.Components;

public partial class Button
{
    [Parameter]
    public string StartIcon { get; set; }

    [Parameter]
    public string EndIcon { get; set; }

    [Parameter]
    public string Text { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }

    [Parameter]
    public ButtonType ButtonType { get; set; } = ButtonType.Button;

    [Parameter]
    public Size Size { get; set; } = Size.Medium;

    [Parameter]
    public Variant Variant { get; set; } = Variant.Filled;

    [Parameter]
    public Color Color { get; set; } = Color.Default;

    [Parameter]
    public BorderVariant BorderVariant { get; set; } = BorderVariant.Default;

    [Parameter]
    public bool FullWidth { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

    protected string ClassName => new CssBuilder().AddClass("btn")
                                                  .AddClass($"btn-{Size.ToDescriptionString()}")
                                                  .AddClass($"btn-{Color.ToDescriptionString()}")
                                                  .AddClass($"btn-{Variant.ToDescriptionString()}", Variant != Variant.Filled)
                                                  .AddClass($"btn-{BorderVariant.ToDescriptionString()}", BorderVariant != BorderVariant.Default)
                                                  .AddClass("btn-block", FullWidth)
                                                  .AddClass("disabled", Disabled)
                                                  .AddClass(Class)
                                                  .ToString();
}
