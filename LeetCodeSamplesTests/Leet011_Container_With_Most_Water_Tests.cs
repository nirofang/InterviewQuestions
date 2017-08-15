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
    public class Leet011_Container_With_Most_Water_Tests
    {
        [TestMethod()]
        public void MaxArea_Test()
        {
            Assert.AreEqual(2, new Leet011_Container_With_Most_Water().MaxArea(new int[] { 1, 2, 3 }));
        }
    }
}