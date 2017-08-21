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
    public class Leet014_Longest_Common_Prefix_Tests
    {
        [TestMethod()]
        public void LongestCommonPrefix_Test()
        {
            Assert.AreEqual(new Leet014_Longest_Common_Prefix().LongestCommonPrefix(new string[] { "abcdefg", "abczzc2", "abc93dfjaj" }), "abc");

            Assert.AreEqual(new Leet014_Longest_Common_Prefix().LongestCommonPrefix(new string[] { "abcdefg", "abcdefg", "abcdefg" }), "abcdefg");

            Assert.AreEqual(new Leet014_Longest_Common_Prefix().LongestCommonPrefix(new string[] { "abcdefgzxc", "abcdefgzze", "abcdefg" }), "abcdefg");


            Assert.AreEqual(new Leet014_Longest_Common_Prefix().LongestCommonPrefix_Own(new string[] { "abcdefg", "abczzc2", "abc93dfjaj" }), "abc");

            Assert.AreEqual(new Leet014_Longest_Common_Prefix().LongestCommonPrefix_Own(new string[] { "abcdefg", "abcdefg", "abcdefg" }), "abcdefg");

            Assert.AreEqual(new Leet014_Longest_Common_Prefix().LongestCommonPrefix_Own(new string[] { "abcdefgzxc", "abcdefgzze", "abcdefg" }), "abcdefg");


        }
    }
}