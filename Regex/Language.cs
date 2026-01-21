
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class LanguageExtractor
{
    public static List<string> Extract(string text)
    {
        List<string> languages = new List<string>();

        string pattern = @"\b(Java|Python|JavaScript|Go)\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            languages.Add(match.Value);
        }

        return languages;
    }
}
