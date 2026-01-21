using System;
using System.Text.RegularExpressions;
public class LicencePlate
{
    public static void Run(){
    String[] numberplate= {"ap1234","AP1234","AP33","Ap0000"};
    string pattern = @"^[A-Z]{2}[0-9]{4}";
    foreach(string plates in numberplate)
    {
        if(Regex.IsMatch(plates,pattern))
        {
            Console.WriteLine("valid");
            }
            else
            {
                
    Console.WriteLine("invalid"); 
            }
        
    }
    }
}