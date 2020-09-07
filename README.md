# ExplosionAPI
using System;
using System.Linq;
public class Accumul 
{
  public static String Accum(string s) 
  {
     // We will end up with everything joined by dashes
     return String.Join("-",
       // Take the string
       s
         // And normalize it to lower
         .ToLower()
         // Turn each character to a repeated string based on it's index
         .Select((character, index) => new String(character, index + 1))
         // Then turn that string into a string where the first character is upper cased, and the rest is left alone
         .Select(subString => subString.Substring(0,1).ToUpper() + subString.Substring(1))
     );
  }
}