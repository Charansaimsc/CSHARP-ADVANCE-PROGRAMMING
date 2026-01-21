using System.Collections.Generic;
using System.Text.RegularExpressions;
public class EmailExtractor
{
    public static List<string> Extractor(string Text)
    {
    List<string> email = new List<string>();
    string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[A-Za-z]{2,}";
    MatchCollection match = Regex.Matches(Text,pattern);
    foreach(Match matchs in match)
        {
            email.Add(matchs.Value);
        }
        return email;
    }
}