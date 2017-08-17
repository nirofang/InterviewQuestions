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
    public class Leet075_Sort_Colors_Tests
    {
        [TestMethod()]
        public void SortColors_Test()
        {
            int[] input = new int[] {  0, 1, 1, 2, 1, 0, 0, 2, 2, 1, 2, 2  };

            new Leet075_Sort_Colors().SortColors(input);

            int[] exp = new int[] { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 2 };

            CollectionAssert.AreEqual(input, exp);
        }
    }
}