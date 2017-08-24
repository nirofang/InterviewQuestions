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
    public class Leet38_Count_and_Say_Tests
    {
        [TestMethod()]
        public void countAndSay_Test()
        {
            var result = new Leet038_Count_and_Say().countAndSay(1);
            Assert.AreEqual(result, "1");

            result = new Leet038_Count_and_Say().countAndSay(2);
            Assert.AreEqual(result, "11");

            result = new Leet038_Count_and_Say().countAndSay(3);
            Assert.AreEqual(result, "21");

            result = new Leet038_Count_and_Say().countAndSay(4);
            Assert.AreEqual(result, "1211");

            result = new Leet038_Count_and_Say().countAndSay(5);
            Assert.AreEqual(result, "111221");

            result = new Leet038_Count_and_Say().countAndSay(6);
        }
    }
}