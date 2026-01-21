using System.Text.RegularExpressions;

public class BadWordCensor
{
    public static string Censor(string text)
    {
        string pattern = @"\b(damn|stupid)\b";
        return Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
    }
}
