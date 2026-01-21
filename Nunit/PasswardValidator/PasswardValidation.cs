using System;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (password == null || password.Length < 8)
            return false;

        bool hasUppercase = false;
        bool hasDigit = false;

        foreach (char ch in password)
        {
            if (char.IsUpper(ch))
                hasUppercase = true;

            if (char.IsDigit(ch))
                hasDigit = true;
        }

        return hasUppercase && hasDigit;
    }
}
