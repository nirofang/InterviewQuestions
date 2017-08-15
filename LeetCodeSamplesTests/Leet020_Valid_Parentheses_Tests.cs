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
    public class Leet020_Valid_Parentheses_Tests
    {
        [TestMethod()]
        public void IsValid_Test()
        {
            Assert.IsTrue(new Leet020_Valid_Parentheses().IsValid("()[]{}"));
            Assert.IsFalse(new Leet020_Valid_Parentheses().IsValid("([)]{}"));
            Assert.IsTrue(new Leet020_Valid_Parentheses().IsValid("([]){}"));
        }
    }
}