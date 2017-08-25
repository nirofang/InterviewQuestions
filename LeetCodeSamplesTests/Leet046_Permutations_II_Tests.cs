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
    public class Leet046_Permutations_II_Tests
    {
        [TestMethod()]
        public void permuteUnique_Test()
        {
            var exp = new List<List<int>> {
                new List<int>{ 1, 1, 2 }, new List<int>{ 1, 2, 1 }, new List<int>{ 2, 1, 1 }
            };
            var result = new Leet046_Permutations_II().permuteUnique(new int[] { 1, 1, 2 });

            ColOp.AreEqual(result, exp);

        }
    }
}