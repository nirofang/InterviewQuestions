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
    public class Leet097_Interleaving_String_Tests
    {
        [TestMethod()]
        public void IsInterleave_Test()
        {
            string s1 = "aabcc", s2 = "dbbca";

            Assert.IsTrue(new Leet097_Interleaving_String().IsInterleave(s1, s2, "aadbbcbcac"));
            Assert.IsFalse(new Leet097_Interleaving_String().IsInterleave(s1, s2, "aadbbbaccc"));
        }
    }
}