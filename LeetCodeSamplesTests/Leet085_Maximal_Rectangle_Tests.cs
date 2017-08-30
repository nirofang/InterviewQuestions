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
    public class Leet085_Maximal_Rectangle_Tests
    {
        [TestMethod()]
        public void maximalRectangle_Test()
        {
            var arr = new List<List<char>> {
                new List<char>{ '1', '1', '0' },
                new List<char>{ '0', '1', '0' },
                new List<char>{ '1', '1', '0' }
            };

            Assert.AreEqual(3, Leet085_Maximal_Rectangle.maximalRectangle(arr));
        }
    }
}