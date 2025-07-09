/*
ARRAYS (2) - ISWORDPRESENTINCOLLECTION

Implement the IsWordPresentInCollection method, which given an
array of words and a wordToBeChecked, returns true if
wordToBeChecked is present in this collection and false otherwise.

For example:

    -   For words equal to {"one", "two", "three"} and
        wordToBeChecked equal to "hello" the result shall be false
        because the word "hello" is not present in the words array.

    -   For words equal to {"one", "two", "three"} and
        wordToBeChecked equal to "two" the result shall be true
        because the word "two" is present in the words array.
*/

using System;

namespace CodeChallenges
{
    public class Exercise11
    {
        public static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
        {
            //your code goes here
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i] == wordToBeChecked)
                {
                    Console.WriteLine("true");
                    return true;
                }
            }
            Console.WriteLine("false");
            return false;
        }
    }
}
