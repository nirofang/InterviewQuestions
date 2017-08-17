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
    public class Leet058_Length_of_Last_Word_Tests
    {
        [TestMethod()]
        public void LengthOfLastWord_Test()
        {
            Assert.AreEqual(new Leet058_Length_of_Last_Word().LengthOfLastWord("hello world baby"),4);
        }
    }
}