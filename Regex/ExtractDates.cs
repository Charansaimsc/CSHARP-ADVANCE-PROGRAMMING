
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class DateExtractor
{
    public static List<string> Extract(string text)
    {
        List<string> dates = new List<string>();

        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            dates.Add(match.Value);
        }

        return dates;
    }
}
