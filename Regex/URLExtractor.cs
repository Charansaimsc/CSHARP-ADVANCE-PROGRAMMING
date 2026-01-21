using System.Collections.Generic;
using System.Text.RegularExpressions;

public class UrlExtractor
{
    public static List<string> Extract(string text)
    {
        List<string> urls = new List<string>();

        string pattern = @"https?://[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            urls.Add(match.Value);
        }

        return urls;
    }
}
