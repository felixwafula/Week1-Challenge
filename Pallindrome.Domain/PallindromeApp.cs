using System;
using System.Text.RegularExpressions;

namespace Pallindrome.Domain
{
    public class PallindromeApp
    {
        //fields 
        public string inputWord;
        public string reverseWord;

        //constructor
        public PallindromeApp()
        {
        }

        //method
        public void pallindrome()
        {
            //ask user for input.
            System.Console.WriteLine("Please enter a word.");
            inputWord = Console.ReadLine();

            //remove whitespaces
            RegexOptions spacelessWord = RegexOptions.None;
            Regex reg = new Regex("[ ]{1}", spacelessWord);
            inputWord = reg.Replace(inputWord, "");

            //Reverse the input.
            char[] word = inputWord.ToCharArray();
            Array.Reverse(word);
            reverseWord = new string(word);

            //compare the input to the reverseword
            if (inputWord.ToLower().Equals(reverseWord.ToLower()))
            {
                System.Console.WriteLine("Your word is a pallindrome.");
            }
            else
            {
                System.Console.WriteLine("No. That is not a pallindrome.");
            }
        }


    }
}


