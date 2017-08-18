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
    public class Leet115_Distinct_Subsequences_Tests
    {
        [TestMethod()]
        public void NumDistinct_Test()
        {
            Assert.AreEqual(1, new Leet115_Distinct_Subsequences().NumDistinct("ABCDE", "ACE"));
            Assert.AreEqual(1, new Leet115_Distinct_Subsequences().NumDistinct("ABCDE", "ABCD"));
            Assert.AreEqual(1, new Leet115_Distinct_Subsequences().NumDistinct("ABCDE", "CD"));
            Assert.AreEqual(0, new Leet115_Distinct_Subsequences().NumDistinct("ABCDE", "AEC"));
            Assert.AreEqual(3, new Leet115_Distinct_Subsequences().NumDistinct("rabbbit", "rabbit"));
        }
    }
}