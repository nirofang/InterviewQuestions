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
    public class Leet063_Unique_Paths_II_Tests
    {
        [TestMethod()]
        public void UniquePathsWithObstacles_Test()
        {
            Assert.AreEqual(2, new Leet063_Unique_Paths_II().UniquePathsWithObstacles(new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } }));

        }
    }
}