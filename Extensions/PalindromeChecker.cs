using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public class PalindromeChecker
    {
        public bool IsWordPalindrome(string word)
        {
            return word.SequenceEqual(word.Reverse());
        }
    }
}
