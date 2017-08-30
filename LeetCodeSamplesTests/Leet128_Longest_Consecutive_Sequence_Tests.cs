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
    public class Leet128_Longest_Consecutive_Sequence_Tests
    {
        [TestMethod()]
        public void longestConsecutive_Test()
        {
            int[] input = new int[] { 100, 4, 200, 1, 3, 2 };
            var res = Leet128_Longest_Consecutive_Sequence.longestConsecutive(input);
            int[] exp = new int[] { 1, 2, 3, 4 };

            CollectionAssert.AreEqual(res, exp);
        }
    }
}