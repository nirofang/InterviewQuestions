using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSamples.Util;


namespace LeetCodeSamples.Tests
{
    [TestClass()]
    public class Leet018_4Sum_Tests
    {
        [TestMethod()]
        public void FourSum_Test()
        {
            var result = new Leet018_4Sum().FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0);
            Assert.IsTrue(result.Contains(new int[] { -1, 0, 0, 1 }, ColOp.comp));
            Assert.IsTrue(result.Contains(new int[] { -2, -1, 1, 2 }, ColOp.comp));
            Assert.IsTrue(result.Contains(new int[] { -2, 0, 0, 2 }, ColOp.comp));

            result = new Leet018_4Sum().FourSum_Own(new int[] { 1, 0, -1, 0, -2, 2 }, 0);
            Assert.IsTrue(result.Contains(new int[] { -1, 0, 0, 1 }, ColOp.comp));
            Assert.IsTrue(result.Contains(new int[] { -2, -1, 1, 2 }, ColOp.comp));
            Assert.IsTrue(result.Contains(new int[] { -2, 0, 0, 2 }, ColOp.comp));

        }


    }
}