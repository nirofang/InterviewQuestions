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
    public class Leet088_Merge_Sorted_Array_Tests
    {
        [TestMethod()]
        public void Merge_Test()
        {
            int[] input1 = new int[] { 1, 3, 5, 9, 0, 0, 0 };
            int[] input2 = new int[] { 2, 4, 6, 8, 0, 0, 0 };
            new Leet088_Merge_Sorted_Array().Merge(input1
                , 2, input2, 3);

           CollectionAssert.AreEqual(input1.Take(5).ToArray(), new int[]{ 1, 2, 3, 4, 6 });
        }
    }
}