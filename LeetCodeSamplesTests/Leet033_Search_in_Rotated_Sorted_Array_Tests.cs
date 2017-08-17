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
    public class Leet033_Search_in_Rotated_Sorted_Array_Tests
    {
        [TestMethod()]
        public void Search_Test()
        {
            int[] input = new int[] { 0, 1, 2, 4, 5, 6, 7 };
            int index = new Leet033_Search_in_Rotated_Sorted_Array().Search(input, 6);
            Assert.AreEqual(index, 5);

            // Found the second 7, because it is a divide and search
            input = new int[] { 4, 5, 7, 7, 0, 1, 2 };
            index = new Leet033_Search_in_Rotated_Sorted_Array().Search(input, 7);
            Assert.AreEqual(index, 3);


            input = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            index = new Leet033_Search_in_Rotated_Sorted_Array().Search(input, 6);
            Assert.AreEqual(index, 2);

            //int[] exp = new int[] { 4, 5, 6, 7, 0, 1, 2  };
            //CollectionAssert.AreEqual(input, exp);
        }
    }
}