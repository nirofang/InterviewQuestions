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
    public class Leet080_Remove_Duplicates_from_Sorted_Array_II_Tests
    {
        [TestMethod()]
        public void removeDuplicates_Test()
        {
            var input = new int[] { 1, 1, 1, 2, 2, 3 };
            Assert.AreEqual(5, Leet080_Remove_Duplicates_from_Sorted_Array_II.removeDuplicates(input));

            input = new int[] { 1, 1, 1, 2, 3, 3, 3, 3, 5, 5 };
            Assert.AreEqual(7, Leet080_Remove_Duplicates_from_Sorted_Array_II.removeDuplicates(input));

        }
    }
}