namespace Blazor.Experiments.Components.Extensions;

public static class EnumExtensions
{
    /// <summary>
    /// Gets the string value in Description attribute used for an Enum
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    public static string ToDescriptionString(this Enum val)
    {
        var attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);

        return attributes.Length > 0
            ? attributes[0].Description
            : val.ToString().ToLower();
    }
}
