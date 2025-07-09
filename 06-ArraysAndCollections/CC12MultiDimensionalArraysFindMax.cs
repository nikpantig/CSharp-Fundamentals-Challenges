/*
MULTI-DIMENSIONAL ARRAYS - FINDMAX

Implement the FindMax method, which given a two-dimensional
array of integers, returns the maximal value from this array.

If any of the array's dimensions is zero, it means the array is empty,
and the method should return -1.

For example:

    -   for an empty array of size [0,3] the result should be -1

    -   for an array like this, the result should be 12

int[,] numbers = new int[,]
{
    { 3, 5 },
    { -1, 12 },
    { 4, 0 }
};
*/

using System;

namespace CodeChallenges
{
    public class Exercise12
    {
        public static int FindMax(int[,] numbers)
        {
            //your code goes here
            var height = numbers.GetLength(0);
            var width = numbers.GetLength(1);

            if (height == 0 || width == 0)
            {
                return -1;
            }

            int max = numbers[0, 0];

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    if (numbers[i, j] > max)
                    {
                        max = numbers[i, j];
                    }
                }
            }
            Console.WriteLine(max);
            return max;
        }
    }
}
