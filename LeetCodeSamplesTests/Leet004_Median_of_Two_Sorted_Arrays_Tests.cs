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
    public class Leet004_Median_of_Two_Sorted_Arrays_Tests
    {
        [TestMethod()]
        public void FindMedianSortedArrays_Test()
        {
            double result = new Leet004_Median_of_Two_Sorted_Arrays().FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
            Assert.AreEqual(result, 2.0);

            // The median is (2 + 3)/2 = 2.5
            result = new Leet004_Median_of_Two_Sorted_Arrays().FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 });
            Assert.AreEqual(result, 2.5);
        }
    }
}