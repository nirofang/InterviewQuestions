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
    public class Leet009_Palindrome_Number_Tests
    {
        [TestMethod()]
        public void isPalindrom_Test()
        {
            Assert.AreEqual(new Leet009_Palindrome_Number().isPalindrom(1), true);
            Assert.AreEqual(new Leet009_Palindrome_Number().isPalindrom(12), false);
            Assert.AreEqual(new Leet009_Palindrome_Number().isPalindrom(121), true);
            Assert.AreEqual(new Leet009_Palindrome_Number().isPalindrom(1221), true);
            Assert.AreEqual(new Leet009_Palindrome_Number().isPalindrom(12321), true);
        }
    }
}