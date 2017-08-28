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
    public class Leet071_Simplify_Path_Tests
    {
        [TestMethod()]
        public void SimplifyPath_Test()
        {

            Assert.AreEqual("/home", new Leet071_Simplify_Path().SimplifyPath("/home/"));

            Assert.AreEqual("/c", new Leet071_Simplify_Path().SimplifyPath("/a/./b/../../c/"));

            Assert.AreEqual("/home", new Leet071_Simplify_Path().SimplifyPath("/home"));

            Assert.AreEqual("/", new Leet071_Simplify_Path().SimplifyPath("///"));

            Assert.AreEqual("/", new Leet071_Simplify_Path().SimplifyPath("/../../"));
        }
    }
}