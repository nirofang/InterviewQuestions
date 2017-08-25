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
    public class Leet046_Permutations_Tests
    {
        [TestMethod()]
        public void permute_Test()
        {
            var exp = new List<List<int>> {
                new List<int>{ 1, 2, 3 }, new List<int>{ 1, 3, 2 }, new List<int>{ 2, 1, 3 },
                new List<int>{ 2, 3, 1 }, new List<int>{ 3, 1, 2 }, new List<int>{ 3, 2, 1 }
            };
            var result = new Leet046_Permutations().permute(new int[] { 1, 2, 3 });
            Assert.IsTrue(result.All(x => exp.Contains(x, ColOp.comp)));


            result = new Leet046_Permutations().permute2(new int[] { 1, 2, 3 });
            Assert.IsTrue(result.All(x => exp.Contains(x, ColOp.comp)));

            result = new Leet046_Permutations().permute3(new int[] { 1, 2, 3 });
            Assert.IsTrue(result.All(x => exp.Contains(x, ColOp.comp)));

            result = new Leet046_Permutations().permute4(new int[] { 1, 2, 3 });
            Assert.IsTrue(result.All(x => exp.Contains(x, ColOp.comp)));


        }
    }
}