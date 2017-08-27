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
    public class Leet064_Minimum_Path_Sum_Tests
    {
        [TestMethod()]
        public void MinPathSum_Test()
        {
            var map = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int result = new Leet064_Minimum_Path_Sum().MinPathSum(map);
            Assert.AreEqual(result, 21);

            map = new int[,] { { 1, 2, 3 }, { 6, 5, 4 }, { 9, 8, 7 } };
            result = new Leet064_Minimum_Path_Sum().MinPathSum(map);
            Assert.AreEqual(result, 17);

        }
    }
}