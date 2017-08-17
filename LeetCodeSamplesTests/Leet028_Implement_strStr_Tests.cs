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
    public class Leet028_Implement_strStr_Tests
    {
        [TestMethod()]
        public void StrStr_Default_Test()
        {
            int index = new Leet028_Implement_strStr().StrStr_Default("hello world", "llo w");
            Assert.AreEqual(index, 2);

            index = new Leet028_Implement_strStr().StrStr_Default("helloworld", "llo w");
            Assert.AreEqual(index, -1);

        }
    }
}