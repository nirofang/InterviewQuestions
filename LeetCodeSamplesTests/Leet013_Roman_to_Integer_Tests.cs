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
    public class Leet013_Roman_to_Integer_Tests
    {
        [TestMethod()]
        public void RomanToInt_Test()
        {
            Assert.AreEqual(new Leet013_Roman_to_Integer().RomanToInt("DXLII"), 542);
        }
    }
}