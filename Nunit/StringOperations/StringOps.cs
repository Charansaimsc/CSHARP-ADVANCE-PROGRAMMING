using System;
namespace StringOperation{
public class StringUtils
{
    // Reverse a string
    public static string Reverse(string str)
    {
        if (str == null)
            return null;

        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    // Check if palindrome
    public static bool IsPalindrome(string str)
    {
        if (str == null)
            return false;

        string reversed = Reverse(str);
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    // Convert to uppercase
    public static string ToUpperCase(string str)
    {
        if (str == null)
            return null;

        return str.ToUpper();
    }
}
}
