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
    public class Leet065_Valid_Number_Tests
    {
        [TestMethod()]
        public void IsNumber_Test()
        {
            Assert.IsTrue(new Leet065_Valid_Number().IsNumber(" +3.1e-1 "));
        }
    }
}