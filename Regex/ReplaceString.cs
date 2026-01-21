using System.Text.RegularExpressions;

public class SpaceNormalizer
{
    public static string Normalize(string text)
    {
        return Regex.Replace(text, @"\s+", " ");
    }
}
