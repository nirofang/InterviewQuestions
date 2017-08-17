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
    public class Leet087_Scramble_String_Tests
    {
        [TestMethod()]
        public void IsScramble_Test()
        {
            Assert.IsTrue(new Leet087_Scramble_String().IsScramble("great", "rgeat"));
            Assert.IsTrue(new Leet087_Scramble_String().IsScramble("great", "rgtae"));
            Assert.IsTrue(new Leet087_Scramble_String().IsScramble("great", "rgtea"));
            Assert.IsTrue(new Leet087_Scramble_String().IsScramble("great", "egrta"));
            Assert.IsTrue(new Leet087_Scramble_String().IsScramble("great", "ergat"));
            Assert.IsFalse(new Leet087_Scramble_String().IsScramble("great", "ergax"));
        }
    }
}