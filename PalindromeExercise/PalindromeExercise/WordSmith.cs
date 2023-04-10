using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsPalinDrome(string word) {
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            string reversedWord = new string(chars);
            if (word == reversedWord) {
                Console.WriteLine("successful palindrome");
                return true;
            } else {
                Console.WriteLine("Not a palindrome");
                return false;
            }
        }
    }
}
