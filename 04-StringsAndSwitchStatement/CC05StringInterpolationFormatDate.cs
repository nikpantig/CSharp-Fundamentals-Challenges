/*
STRING INTERPOLATION - FORMATDATE

Using string interpolation, implement the
FormatDate method, which given three integers
representing the year, month and day shall return a
string int the format YEAR/MONTH/DAY

For example:

    -   for the year 2022, month 10, and day 29, it shall
        return "2022/10/29"

    -   for the year 1911, month 1, and day 5, it shall
        return "1911/1/5"
*/

using System;

namespace CodeChallenges
{
    public class Exercise05
    {
        public static string FormatDate(int year, int month, int day)
        {
            //your code goes here
            Console.WriteLine($"{year}/{month}/{day}");
            return $"{year}/{month}/{day}";
        }
    }
}
