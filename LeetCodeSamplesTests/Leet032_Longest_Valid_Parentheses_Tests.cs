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
    public class Leet032_Longest_Valid_Parentheses_Tests
    {
        [TestMethod()]
        public void LongestValidParentheses_Test()
        {
            int length = new Leet032_Longest_Valid_Parentheses().LongestValidParentheses("()))(()(()))");
            Assert.AreEqual(length, 8);
        }
    }
}