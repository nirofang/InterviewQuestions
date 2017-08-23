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
    public class Leet026_Remove_Duplicates_from_Sorted_Array_Tests
    {
        [TestMethod()]
        public void RemoveDuplicates_Test()
        {
            int[] input = new int[] { 1, 3, 5, 6, 6, 8, 9, 99, 99, 102 };
            int result = new Leet026_Remove_Duplicates_from_Sorted_Array().RemoveDuplicates(input);
            int[] exp = new int[] { 1, 3, 5, 6, 8, 9, 99, 102 };

            Assert.AreEqual(result, 8);


            var output = input.ToList();
            output.RemoveRange(8 - 1, input.Length - 8);
            CollectionAssert.AreEqual(output, exp);

            input = new int[] { 1, 3, 5, 6, 6, 8, 9, 99, 99, 102 };
            result = new Leet026_Remove_Duplicates_from_Sorted_Array().RemoveDuplicates_Own_Standard(input);

            Assert.AreEqual(result, 8);


            input = new int[] { 1, 3, 5, 6, 6, 8, 9, 99, 99, 102 };
            result = new Leet026_Remove_Duplicates_from_Sorted_Array().RemoveDuplicates_Own_Standard_Simple(input);

            Assert.AreEqual(result, 8);

            input = new int[] { 1, 3, 5, 6, 6, 8, 9, 99, 99, 102 };
            result = new Leet026_Remove_Duplicates_from_Sorted_Array().RemoveDuplicates_Own_2Pointers(input);

            Assert.AreEqual(result, 8);
        }
    }
}