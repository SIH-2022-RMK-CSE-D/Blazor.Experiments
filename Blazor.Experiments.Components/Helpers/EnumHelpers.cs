using Blazor.Experiments.Components.Enums;

namespace Blazor.Experiments.Components.Helpers;

public static class EnumHelpers
{
    public static string ToCssClass(this ContainerMaxSize maxSize)
    {
        return maxSize switch
        {
            ContainerMaxSize.Sm => "container-sm",
            ContainerMaxSize.Md => "container-md",
            ContainerMaxSize.Lg => "container-lg",
            ContainerMaxSize.Xl => "container-xl",
            ContainerMaxSize.Xxl => "container-xxl",
            ContainerMaxSize.Fluid => "container-fluid",
            _ => "container",
        };
    }

    public static string ToHtmlAttributeValue(this ButtonType type)
    {
        return type switch
        {
            ButtonType.Submit => "submit",
            ButtonType.Reset => "reset",
            _ => "button"
        };
    }
}
