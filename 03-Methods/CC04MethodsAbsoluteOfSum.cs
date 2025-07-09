/*
METHODS - ABSOLUTEOFSUM METHOD

Define the AbsoluteOfSum method, w/c takes two
int parameters, and returns the absolute value of
their sum

Absolute value is the non-negative value of the
number, without regard to its sign. So for example,
the absolute value of 5 is 5, and the absolute value of
-10 is 10
*/

using System;

namespace CodeChallenges
{
    public class Exercise04
    {
        public static int AbsoluteOfSum(int num1, int num2)
        {
            //your code goes here
            var sum = num1 + num2;

            if(sum < 0)
            {
                Console.WriteLine($"Absolute Sum: {-sum}");
                return -sum;
            }

            Console.WriteLine($"Absolute Sum: {sum}");
            return sum;
        }
    }
}
