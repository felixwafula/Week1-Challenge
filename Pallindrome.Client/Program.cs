using System;
using Pallindrome.Domain;

namespace Pallindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PallindromeApp word = new PallindromeApp();
            word.pallindrome();
        }
    }
}
