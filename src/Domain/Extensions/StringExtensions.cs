namespace DongPhuong.Domain.Extensions;

public static class StringExtensions
{
    public static string ToPlural(this string s) =>
        s.Append('s').ToString() ?? throw new InvalidOperationException("String must not be null.");
}