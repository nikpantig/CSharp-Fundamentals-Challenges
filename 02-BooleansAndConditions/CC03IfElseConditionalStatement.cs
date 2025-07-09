/*
IF/ELSE CONDITIONAL STATEMENT

To the result variable, assign a string according to the
following rules:

    -   if number is smaller than zero, it should be
        "negative"
    -   if number is exactly zero, it should be "zero"
    -   if number is larger than zero, it should be
        "positive
*/

using System;

namespace CodeChallenges
{
    public class Exercise03
    {
        public static string IfElseConditionalStatement()
        {
            int number = 0;

            string result;

            //your code goes here
            if (number < 0)
            {
                result = "negative";
            }
            else if (number == 0)
            {
                result = "zero";
            }
            else
            {
                result = "positive";
            }
            
            Console.WriteLine(result);

            return result;
        }
    }
}
