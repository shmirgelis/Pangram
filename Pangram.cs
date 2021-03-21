using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if(input == "")
        {
            return false;
        }
        else
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            input = input.ToLower();
            char[] inputChars = input.ToCharArray();
            char[] alphabetChars = alphabet.ToCharArray();
            var orderedInput = inputChars.Where(c => Char.IsLetter(c))
                                         .OrderBy(c => c)
                                         .Distinct()
                                         .Select(c => c.ToString())
                                         .Aggregate((c1, c2) => c1 += c2);

            return orderedInput == alphabet;
        }
        
        
    }
}
