﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Extensions;
using Extensions;

namespace LoanApplication.Tests.Unit
{
    public class TheoryTest
    {
        [Theory,
         InlineData("name"),
         InlineData("city")]
        public void TestCheckWordLength_ShouldReturnBoolean(string word)
        {
            Assert.Equal(4, word.Length);
        }

        [Theory, MemberData("GetMethodData")]
        public void TestCheckWordLength2_ShouldReturnBoolean(string word)
        {
            Assert.Equal(4, word.Length);
        }

        public static IEnumerable<object[]> GetMethodData => new[]
        {
            new object[] {"word"},
            new object[] {"name"}
        };


        [Theory, ClassData(typeof(TestData))]
        public void TestCheckWordLength3_ShouldReturnBoolean(string word)
        {
            Assert.Equal(4, word.Length);
        }
    }



    public class TestData : IEnumerable<object[]>
    {
        private IEnumerable<object[]> data => new[]
        {
            new object[] {"word"},
            new object[] {"name"}
        };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }


    public class GCDTest
    {

        [Theory, CsvData(@"C:\gcd.csv", false)]
        public void Test_GetGcd_ShouldRetunTrue(int firstNumber, int secondNumber, int gcd)
        {
            int gcdValue = GetGcd(firstNumber, secondNumber);
            Assert.Equal(gcd, gcdValue);
        }

        public int GetGcd(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
                return firstNumber;
            else
                return GetGcd(secondNumber, firstNumber % secondNumber);
        }
    }
}
