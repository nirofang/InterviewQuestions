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
    public class Leet067_Add_Binary_Tests
    {
        [TestMethod()]
        public void AddBinary_Test()
        {
            Assert.AreEqual("1110", new Leet067_Add_Binary().AddBinary("1011", "11"));


            Assert.AreEqual("1110", new Leet067_Add_Binary().AddBinary("11", "1011"));
        }
    }
}