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
    public class Leet069_Sqrtx_Tests
    {
        [TestMethod()]
        public void mySqrt_Test()
        {
            Assert.AreEqual(5, Leet069_Sqrtx.mySqrt(25));

            Assert.AreEqual(5, Leet069_Sqrtx.mySqrt2(25));
        }
    }
}