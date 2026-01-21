using System.Text.RegularExpressions;

public class IpValidator
{
    public static bool IsValid(string ip)
    {
        string pattern =
            @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}" +
            @"(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$";

        return Regex.IsMatch(ip, pattern);
    }
}
