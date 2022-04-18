namespace Blazor.Experiments.Components;

public enum Variant : byte
{
    Filled,
    [Description("ghost")]
    Text,
    [Description("outline")]
    Outlined
}
