using System;
using System.Text.RegularExpressions;
class ValidateUSer
{
    public static void Run()
    {
        string[] name = {"cha","sai_123","konda_sai_123","123konda_"};
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{5,15}";
        foreach(string names in name)
        {
            if (Regex.IsMatch(names, pattern))
            {
                Console.WriteLine("valid username");
            }
            else
            {
                Console.WriteLine("invalidUsername");
                if(names.Length<5)Console.WriteLine("too short");
            }
        }
    }
}