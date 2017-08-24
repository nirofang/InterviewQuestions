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
    public class Leet044_Wildcard_Matching_Tests
    {

        [TestMethod()]
        public void isMatch_Test()
        {
            Assert.IsTrue(Leet044_Wildcard_Matching.isMatch("ab", "a*"));


            Assert.IsTrue(Leet044_Wildcard_Matching.isMatch("abcd", "a*d"));

            Assert.IsTrue(Leet044_Wildcard_Matching.isMatch("abcdeefg", "a*d*fg"));


            Assert.IsTrue(Leet044_Wildcard_Matching.isMatch2("abcdeefg", "a*d*fg"));
        }
    }
}