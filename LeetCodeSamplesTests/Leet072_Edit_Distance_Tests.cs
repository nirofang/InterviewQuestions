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
    public class Leet072_Edit_Distance_Tests
    {
        [TestMethod()]
        public void MinDistance_Test()
        {
            int result = new Leet072_Edit_Distance().MinDistance("hello", "world");
        }
    }
}