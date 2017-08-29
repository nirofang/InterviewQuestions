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
    public class Leet136_Single_Number_Tests
    {
        [TestMethod()]
        public void SingleNumber_Test()
        {
            Assert.AreEqual(3,Leet136_Single_Number.SingleNumber(
                new int[]{ 1, 1, 2, 2, 3, 5, 5 }));

            Assert.AreEqual(5, Leet136_Single_Number.SingleNumber(
                new int[] { 1, 1, 2, 2, 4, 4, 5, 666, 666, 7777, 7777, 888888, 888888 }));


            Assert.AreEqual(3, Leet136_Single_Number.SingleNumber2(
                new int[] { 1, 1, 2, 2, 3, 5, 5 }));

            Assert.AreEqual(5, Leet136_Single_Number.SingleNumber2(
                new int[] { 1, 1, 2, 2, 4, 4, 5, 666, 666, 7777, 7777, 888888, 888888 }));

            Assert.AreEqual(888888, Leet136_Single_Number.SingleNumber2(
    new int[] { 1, 1, 2, 2, 4, 4, 5,5, 666, 666, 7777, 7777, 888888, 99,99 }));
        }
    }
}