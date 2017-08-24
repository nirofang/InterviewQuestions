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
    public class Leet042_Trapping_Rain_Water_Tests
    {
        [TestMethod()]
        public void trapWater_Test()
        {
            var result = new Leet042_Trapping_Rain_Water().trapWater(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
            Assert.AreEqual(result, 6);

        }
    }
}