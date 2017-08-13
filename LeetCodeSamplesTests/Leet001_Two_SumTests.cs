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
    public class Leet001_Two_SumTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            int[] result = new Leet001_Two_Sum().TwoSum(new int[] { 1, 2, 3 }, 3);

            CollectionAssert.AreEqual(result, new int[] { 0, 1 });

            try
            {
                new Leet001_Two_Sum().TwoSum(null, 3);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.GetType(), typeof(ArgumentNullException));
            }
        }

        [TestMethod()]
        public void TwoSum2Test()
        {
            int[] result = new Leet001_Two_Sum().TwoSum(new int[] { 1, 2, 3 }, 3);

            CollectionAssert.AreEqual(result, new int[] { 0, 1 });
        }
    }
}