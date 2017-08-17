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
    public class Leet084_Largest_Rectangle_in_Histogram_Tests
    {
        [TestMethod()]
        public void LargestRectangleArea_Test()
        {
            Assert.AreEqual(10, new Leet084_Largest_Rectangle_in_Histogram().
                LargestRectangleArea(new int[] { 2, 1, 5, 6, 2, 3 }));
        }
    }
}