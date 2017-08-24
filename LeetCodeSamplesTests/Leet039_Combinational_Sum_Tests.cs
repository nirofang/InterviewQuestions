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
    public class Leet039_Combinational_Sum_Tests
    {
        [TestMethod()]
        public void combinationalSum_Test()
        {
            var res = new Leet039_Combinational_Sum().combinationalSum(new int[] { 2, 3, 6, 7 }, 7);
            List<List<int>> exp = new List<List<int>>{ new List<int> { 2, 2, 3 }, new List<int>() { 7 }};

            for (int i = 0; i < res.Count; i++)
            {
                CollectionAssert.AreEqual(res[i], exp[i]);
            }


            res = new Leet039_Combinational_Sum().combinationalSum(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);
        }
    }
}