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
    public class Leet034_Search_for_a_Range_Tests
    {
        [TestMethod()]
        public void SearchRange_Test()
        {
            int[] input = new int[] { 0, 1, 2, 4, 6, 6, 7 };
            var range = new Leet034_Search_for_a_Range().SearchRange(input, 6);
            
            CollectionAssert.AreEqual(range, new int[]{ 4, 5 });

            range = new Leet034_Search_for_a_Range().SearchRange_Own(input, 6);
            CollectionAssert.AreEqual(range, new int[] { 4, 5 });
        }
    }
}