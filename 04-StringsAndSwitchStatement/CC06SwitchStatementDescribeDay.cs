/*
SWITCH STATEMENT - DESCRIBEDAY

Implement the DescribeDay method, which given a
day of the week as a number, should return:

    -   "Working day" for numbers 1 to 5
    -   "Weekend" for numbers 6 and 7
    -   "Invalid day number" for any other number
*/

using System;

namespace CodeChallenges
{
    public class Exercise06
    {
        public static string DescribeDay(int dayNumber)
        {
            //your code goes here
            switch(dayNumber)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Working day");
                    return "Working day";
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    return "Weekend";
                default:
                    Console.WriteLine("invalid day number");
                    return "invalid day number";
            }
        }
    }
}
