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
    public class Leet052_NQueen_II_Tests
    {
        [TestMethod()]
        public void totalNQueensII_Test()
        {
            Assert.AreEqual(2, Leet052_NQueen_II.totalNQueensII(4));
            Assert.AreEqual(2, Leet052_NQueen_II.totalNQueensII2(4));
            Assert.AreEqual(2, Leet052_NQueen_II.totalNQueensII3(4));
        }
    }
}