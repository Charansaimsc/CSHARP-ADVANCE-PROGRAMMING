using System.Text.RegularExpressions;

public class HexColorValidator
{
    public static bool IsValid(string color)
    {
        return Regex.IsMatch(color, "^#[0-9A-Fa-f]{6}$");
    }
}
