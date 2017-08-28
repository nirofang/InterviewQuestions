using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSamples.Util;

namespace LeetCodeSamples.Tests
{
    [TestClass()]
    public class Leet077_Combinations_Tests
    {
        [TestMethod()]
        public void combine_Test()
        {
            var res = Leet077_Combinations.combine(4, 2);
            var exp = new List<List<int>> {
                new List<int> { 1, 2},
                new List<int> { 1, 3},
                new List<int> { 1, 4},
                new List<int> { 2, 3},
                new List<int> { 2, 4},
                new List<int> { 3, 4}
            };

            ColOp.AreEqual(res, exp);
        }
    }
}