using System.Text.RegularExpressions;

public class CreditCardValidator
{
    public static bool IsValid(string cardNumber)
    {
        string pattern = @"^(4|5)\d{15}$";
        return Regex.IsMatch(cardNumber, pattern);
    }
}
