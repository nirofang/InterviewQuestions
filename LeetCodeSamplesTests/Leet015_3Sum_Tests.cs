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
    public class Leet015_3Sum_Tests
    {
        /// <summary>
        /// https://leetcode.com/problems/3sum/description/
        /// Expect 3 sums = 0
        /// </summary>
        [TestMethod()]
        public void ThreeSum_Test()
        {
            var result = new Leet015_3Sum().ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });

            CollectionAssert.AreEqual(result[0].ToArray(), new int[] { -1, -1, 2 });
            CollectionAssert.AreEqual(result[1].ToList(), new List<int> { -1, 0, 1 });

            //CollectionAssert.AreEqual(result.Select(x=>x.ToList()).ToList(), 
            //    new List<List<int>> { new List<int>{ -1, 0, 1 }, new List<int> { -1, 0, 1 } });

            result = new Leet015_3Sum().ThreeSum_Own(new int[] { -1, 0, 1, 2, -1, -4 });

            CollectionAssert.AreEqual(result[0].ToArray(), new int[] { -1, -1, 2 });
            CollectionAssert.AreEqual(result[1].ToList(), new List<int> { -1, 0, 1 });
        }
    }
}