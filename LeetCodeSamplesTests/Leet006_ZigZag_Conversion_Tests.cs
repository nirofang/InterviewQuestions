using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples.Tests
{
    /// <summary>
    /// https://leetcode.com/problems/zigzag-conversion/description/
    /// 
    /// P   A   H   N
    /// A P L S I I G
    /// Y   I   R
    /// 
    /// P   I   N
    /// A L S I G
    /// Y A H R 
    /// P   I
    /// 
    /// </summary>
    [TestClass()]
    public class Leet006_ZigZag_Conversion_Tests
    {
        [TestMethod()]
        public void Convert_Test()
        {
            string result = new Leet006_ZigZag_Conversion().ZigZag_Convert("PAYPALISHIRING", 3);
            Assert.AreEqual(result, "PAHNAPLSIIGYIR");

            result = new Leet006_ZigZag_Conversion().ZigZag_Convert("PAYPALISHIRING", 4);
            Assert.AreEqual(result, "PINALSIGYAHRPI");


            result = new Leet006_ZigZag_Conversion().ZigZag_Convert_Own("PAYPALISHIRING", 3);
            Assert.AreEqual(result, "PAHNAPLSIIGYIR");

            result = new Leet006_ZigZag_Conversion().ZigZag_Convert_Own("PAYPALISHIRING", 4);
            Assert.AreEqual(result, "PINALSIGYAHRPI");
        }
    }
}