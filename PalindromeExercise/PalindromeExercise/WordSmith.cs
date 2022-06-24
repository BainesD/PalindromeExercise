using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith

    {
        public WordSmith()
        {

        }
        public bool IsAPalindrome(string word)
        {
            //Original, but I may try to refactor
            //string wordInput = word.ToLower();
            //char[] wordReversedArr = word.ToLower().ToCharArray();
            //string wordReversed = string.Empty;
            //for (int i = wordReversedArr.Length - 1; i >= 0; i--)
            //{
            //    wordReversed += wordReversedArr[i];
            //}
            //return wordReversed == wordInput;

            //string wordInput = word.ToLower();
            //char[] wordInputArr = word.ToLower().ToCharArray()
            //Array.Reverse(wordInputArr);
            //string reversedWord = new string(wordInputArr);
            //return wordInput == reversedWord;
            return word.ToLower().SequenceEqual(word.ToLower().Reverse());
        }
        public char[] CustomReverse(char[] arr1)
        {
            Array.Reverse(arr1);
            return arr1;
        }
    }
}
