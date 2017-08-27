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
    public class Leet070_Climbing_Stairs_Tests
    {
        [TestMethod()]
        public void climbStairs_Test()
        {
            Assert.AreEqual(3, Leet070_Climbing_Stairs.climbStairs(3));
        }
    }
}