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
    public class Leet010_Regular_Expression_Matching_Tests
    {
        [TestMethod()]
        public void IsMatch_Test()
        {

            Assert.AreEqual(new Leet010_Regular_Expression_Matching().IsMatch("ab", ".*"), true);
            Assert.AreEqual(new Leet010_Regular_Expression_Matching().IsMatch("aaaaaaaab5", "a*b."), true);


        }

        [TestMethod()]
        public void IsMatch2_Test()
        {
            Assert.AreEqual(new Leet010_Regular_Expression_Matching().IsMatch2("a*b.4", "a234ssd3fb54"), false);
            Assert.AreEqual(new Leet010_Regular_Expression_Matching().IsMatch2("a234ssd3fb54", "a*b.4"), false);
            Assert.AreEqual(new Leet010_Regular_Expression_Matching().IsMatch2("ab", ".*"), true);
            Assert.AreEqual(new Leet010_Regular_Expression_Matching().IsMatch2("aaaaaaaab5", "a*b."), true);
        }
    }
}