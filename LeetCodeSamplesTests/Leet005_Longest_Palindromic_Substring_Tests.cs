using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples.Tests
{
    [TestClass()]
    public class Leet005_Longest_Palindromic_Substring_Tests
    {
        [TestMethod()]
        public void LongestPalindrome_Test()
        {
            string result = new Leet005_Longest_Palindromic_Substring().LongestPalindrome("babad");
            Assert.AreEqual(result, "bab");

            result = new Leet005_Longest_Palindromic_Substring().LongestPalindrome("cbbd");
            Assert.AreEqual(result, "bb");

            result = new Leet005_Longest_Palindromic_Substring().LongestPalindrome("abcbbd");
            Assert.AreEqual(result, "bcb");

            result = new Leet005_Longest_Palindromic_Substring().LongestPalindrome("abccbbaccab");
            Assert.AreEqual(result, "baccab");
        }
    }
}