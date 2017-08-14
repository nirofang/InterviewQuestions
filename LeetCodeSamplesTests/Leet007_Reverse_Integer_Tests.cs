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
    public class Leet007_Reverse_Integer_Tests
    {
        [TestMethod()]
        public void Reverse_Integer_Test()
        {
            Assert.AreEqual(321, new Leet007_Reverse_Integer().Reverse_Integer(123));

            Assert.AreEqual(321, new Leet007_Reverse_Integer().Reverse_Integer_Default(123));
        }
    }
}