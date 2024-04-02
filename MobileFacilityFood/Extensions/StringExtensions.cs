namespace MobileFacilityFood.Extensions;

public static class StringExtensions
{
    public static bool IsNullOrWhiteSpace(this string? target)
    {
        return string.IsNullOrWhiteSpace(target);
    }

    public static bool IsNotNullOrWhiteSpace(this string? target)
    {
        return !target.IsNullOrWhiteSpace();
    }
}