using System.Collections.Generic;
using System.Text.RegularExpressions;

public class CapitalizedWordExtractor
{
    public static List<string> Extract(string text)
    {
        List<string> words = new List<string>();

        string pattern = @"\b[A-Z][a-z]+\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            words.Add(match.Value);
        }

        return words;
    }
}
