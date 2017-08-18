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
    public class Leet119_Pascals_Triangle_II_Tests
    {
        [TestMethod()]
        public void GetRow_Test()
        {
            var result = new Leet119_Pascals_Triangle_II().GetRow(3);
            CollectionAssert.AreEqual(result.ToArray(), new int[] { 1, 3, 3, 1 });
        }
    }
}