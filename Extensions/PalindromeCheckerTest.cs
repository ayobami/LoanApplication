using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Extensions
{
    public class PalindromeCheckerTest
    {
        [Theory, SqlServerData(@".\sqlexpress", "TheoryDb", "select word from Palindrome")]
        public void Test_IsWordPalindrome_ShouldReturnTrue(string word)
        {
            PalindromeChecker palindromeChecker = new PalindromeChecker();
            Assert.True(palindromeChecker.IsWordPalindrome(word));
        }


        //[Theory, CsvData(@"C:\data.txt", false)]
        //public void Test_IsWordPalindrome_ShouldReturnTrue(string word)
        //{
        //    PalindromeChecker palindromeChecker = new PalindromeChecker();

        //    Assert.True(palindromeChecker.IsWordPalindrome(word));


        //}
    }
}
