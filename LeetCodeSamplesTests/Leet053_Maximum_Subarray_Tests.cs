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
    public class Leet053_Maximum_Subarray_Tests
    {
        [TestMethod()]
        public void MaxSubArray_Test()
        {
            int[] input = new int[] { 1, 3, 5, 6, 6, 8, 9, 99, 99, 102 };
            Assert.AreEqual(338, new Leet053_Maximum_Subarray().MaxSubArray(input));


            input = new int[] { -1, 3, -5, 6, -6, 8, -9};
            Assert.AreEqual(8, new Leet053_Maximum_Subarray().MaxSubArray(input));

            input = new int[] { -2, 1,-3, 4,-1, 2, 1,-5, 4};
            Assert.AreEqual(6, new Leet053_Maximum_Subarray().MaxSubArray(input));




            input = new int[] { 1, 3, 5, 6, 6, 8, 9, 99, 99, 102 };
            Assert.AreEqual(338, new Leet053_Maximum_Subarray().maxSubArray2(input));


            input = new int[] { -1, 3, -5, 6, -6, 8, -9 };
            Assert.AreEqual(8, new Leet053_Maximum_Subarray().maxSubArray2(input));

            input = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Assert.AreEqual(6, new Leet053_Maximum_Subarray().maxSubArray2(input));


        }
    }
}