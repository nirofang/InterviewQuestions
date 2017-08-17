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
    public class Leet081_Search_in_Rotated_Sorted_Array_II_Tests
    {
        [TestMethod()]
        public void Search_Test()
        {
            //int[] input = new int[] { 0, 1, 2, 4, 5, 6, 7 };
            int[] input = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            Assert.IsTrue(new Leet081_Search_in_Rotated_Sorted_Array_II().Search(input, 2));
            Assert.IsFalse(new Leet081_Search_in_Rotated_Sorted_Array_II().Search(input, 8));
        }
    }
}