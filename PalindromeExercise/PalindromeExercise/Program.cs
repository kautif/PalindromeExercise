using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            WordSmith palindrome = new WordSmith();
            Console.WriteLine("Is your word a palindrome?");
            string word = Console.ReadLine();
            palindrome.IsPalinDrome(word);
        }
    }
}
