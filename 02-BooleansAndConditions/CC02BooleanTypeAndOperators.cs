/*
BOOLEAN TYPE AND OPERATORS

To the isSumLargerOrEqualTo17 variable, assign
true if the sum of a and b is larger or equal to 17 and
false otherwise
*/

using System;

namespace CodeChallenges
{
    public class Exercise02
    {
        public static bool BooleanTypesAndOperators()
        {
            int a = 5;
            int b = 12;

            bool isSumLargerOrEqualTo17 = (a + b) >= 17; //your code goes here

            Console.WriteLine(isSumLargerOrEqualTo17);

            return isSumLargerOrEqualTo17;
        }
    }
}