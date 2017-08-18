using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples.Tests
{

// 'A' -> 1
//'B' -> 2
//...
//'Z' -> 26

    [TestClass()]
    public class Leet091_Decode_Ways_Tests
    {
        [TestMethod()]
        public void NumDecodings_Test()
        {
            Assert.AreEqual(2, new Leet091_Decode_Ways().NumDecodings("12"));
        }
    }
}