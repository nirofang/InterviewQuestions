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
            int result = new Leet064_Minimum_Path_Sum().MinPathSum(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
            Assert.AreEqual(result, 21);
        }
    }
}