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
    public class Leet066_Plus_One_Tests
    {
        [TestMethod()]
        public void PlusOne_Test()
        {
            var res = new Leet066_Plus_One().PlusOne(new int[] { 1, 3, 5,7,3,1});
            CollectionAssert.AreEqual(res, new int[] { 1, 3, 5, 7, 3, 2 });

            res = new Leet066_Plus_One().PlusOne(new int[] { 1, 3, 9, 9, 9, 9 });
            CollectionAssert.AreEqual(res, new int[] { 1, 4, 0, 0, 0, 0 });

        }
    }
}