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
    public class Leet040_Combinational_Sum_II_Tests
    {
        [TestMethod()]
        public void combinationalSum2_Test()
        {
            var res = new Leet040_Combinational_Sum_II().
                combinationalSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);

            List<List<int>> exp = new List<List<int>> {
                new List<int> { 1, 1, 6 },
                new List<int> { 1, 2, 5 },
                new List<int>() { 1, 7 },
                new List<int>() { 2, 6 } };

            for (int i = 0; i < res.Count; i++)
            {
                CollectionAssert.AreEqual(res[i], exp[i]);
            }

        }
    }
}