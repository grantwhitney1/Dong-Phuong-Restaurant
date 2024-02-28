namespace DongPhuong.Domain.Extensions;

public static class StringExtensions
{
    public static string ToPlural(this string s)
    {
        return string.IsNullOrEmpty(s)
            ? throw new InvalidOperationException("String must not be null or empty.")
            : s + "s";
    }
}