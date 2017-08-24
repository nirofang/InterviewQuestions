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
    public class Leet043_Multiply_String_Tests
    {
        [TestMethod()]
        public void multiplyString_Test()
        {
            var res = new Leet043_Multiply_String().multiplyString("12", "20");
            Assert.AreEqual(res, "240");
        }
    }
}