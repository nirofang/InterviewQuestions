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
    public class Leet008_String_to_Integer_atoi_Tests
    {
        [TestMethod()]
        public void MyAtoi_Test()
        {
            Assert.AreEqual(new Leet008_String_to_Integer_atoi().MyAtoi("  -1123 "), -1123);

            Assert.AreEqual(new Leet008_String_to_Integer_atoi().MyAtoi("  12312412341 "), int.MaxValue);
        }
    }
}