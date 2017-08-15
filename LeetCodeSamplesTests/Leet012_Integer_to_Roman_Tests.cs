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
    public class Leet012_Integer_to_Roman_Tests
    {
        [TestMethod()]
        public void IntToRoman_Test()
        {
            Assert.AreEqual(new Leet012_Integer_to_Roman().IntToRoman(542), "DXLII");
        }
    }
}