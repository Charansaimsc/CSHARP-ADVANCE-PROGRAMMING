using System;
using System.Text.RegularExpressions;
namespace regexx
{
    public class Program
    {
        static void Main(string[] args)
        {
           // ValidateUSer.Run();
            //LicencePlate.Run();
              //Console.WriteLine(HexColorValidator.IsValid("#FFA500") ? "Valid" : "Invalid");
              // EmailExtractor.Extractor("Contact us at support@example.com and info@company.org").ForEach(Console.WriteLine);



            //    foreach (string word in CapitalizedWordExtractor.Extract("The Eiffel Tower is in Paris and the Statue of Liberty is in New York."))
            //     {
            //          Console.WriteLine(word);
            //      }


        //     foreach (string date in DateExtractor.Extract(
        //     "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020."
        // ))
        // {
        //     Console.WriteLine(date);
        // }


        // foreach (string url in UrlExtractor.Extract(
        //     "Visit https://www.google.com and http://example.org for more info."
        // ))
        // {
        //     Console.WriteLine(url);
        // }


                // string input = "This   is   an   example   with   multiple   spaces.";
                // Console.WriteLine(SpaceNormalizer.Normalize(input));
       
       
       
        // string input = "This is a damn bad example with some stupid words.";
        // Console.WriteLine(BadWordCensor.Censor(input));


        //  Console.WriteLine(IpValidator.IsValid("192.168.1.1"));  

        // Console.WriteLine(IpValidator.IsValid("256.1.1.1"));     
        // Console.WriteLine(IpValidator.IsValid("192.168.1")); 


        //  Console.WriteLine(CreditCardValidator.IsValid("4123456789012345")); 
        // Console.WriteLine(CreditCardValidator.IsValid("5123456789012345")); 
        // Console.WriteLine(CreditCardValidator.IsValid("6123456789012345"));  
       


       foreach (string lang in LanguageExtractor.Extract(
            "I love Java, Python, and JavaScript, but I haven't tried Go yet."
        ))
        {
            Console.WriteLine(lang);
        }
        }

    }
}