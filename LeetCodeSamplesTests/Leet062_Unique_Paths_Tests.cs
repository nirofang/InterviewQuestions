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
    public class Leet062_Unique_Paths_Tests
    {
        [TestMethod()]
        public void UniquePaths_Test()
        {
            Assert.AreEqual(3, new Leet062_Unique_Paths().UniquePaths(2, 3));
        }
    }
}