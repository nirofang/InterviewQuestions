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
    public class Leet076_Minimum_Window_Substring_Tests
    {
        [TestMethod()]
        public void MinWindow_Test()
        {
            Assert.AreEqual("BANC", new Leet076_Minimum_Window_Substring().MinWindow("ADOBECODEBANC", "ABC"));

        }
    }
}