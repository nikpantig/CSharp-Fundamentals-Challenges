/*
DO-WHILE-LOPP - REPEATCHARACTER

Using the for loop, implement the Factorial method, which
calculates the factorial of a given number.

Factorial of number N is the result of multiplying all integers
from 1 to N.

N! = 1*2*3*...*(N-1)*N

For example:
    -   5! = 1*2*3*4*5 = 120
    -   4! = 1*2*3*4 = 24
    -   1! = 1
    -   0! = 1 (by convention)

Assume the number parameter is non-negative
*/

using System;

namespace CodeChallenges
{
    public class Exercise09
    {
        public static int Factorial(int number)
        {
            //your code goes here
            int result = 1;

            for(int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
