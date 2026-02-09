using System;
using System.Collections.Generic;
using System.Linq;
static class StringSorter
{
   public static void Run()
    {
        List<string> Word = new List<string>
        {
          "hello","world","wecome","you"  
        };
        var sortedwords = Word.OrderBy(w=>w.Length);
        foreach(string word in sortedwords)
        {
            Console.WriteLine(word);
        }
    }
}