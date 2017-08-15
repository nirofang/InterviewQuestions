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
    public class Leet016_3Sum_Closest_Tests
    {
        [TestMethod()]
        public void ThreeSumClosest_Test()
        {
            // -1 1 2
            var result = new Leet016_3Sum_Closest().ThreeSumClosest(new int[] { -1, 0, 1, 2, -1, -4 }, 2);

        }
    }
}