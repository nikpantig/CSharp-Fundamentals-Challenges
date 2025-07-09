/*
ARRAYS (1) - BUILDHELLOSTRING

The purpose of the BuildHelloString is to iterate an array of chars
consisting of all letters of the word "hello" and add those letters to
the result string variable, so at the end of this method, this variable is
equal to "hello".
*/

using System;

namespace CodeChallenges
{
    public class Exercise10
    {
        public static string BuildHelloString()
        {
            char[] letters = new char[] { 'h', 'e', 'l', 'l', 'o' };
            
            //your code goes here
            var result = "";

            for(int i = 0; i < letters.Length; i++)
            {
                result += letters[i];
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
