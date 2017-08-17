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
    public class Leet027_Remove_Element_Tests
    {
        [TestMethod()]
        public void RemoveElement_Test()
        {
            int[] input = new int[] { 1, 3, 5, 6, 6, 8, 99, 99, 99, 102 };
            Assert.AreEqual(new Leet027_Remove_Element().RemoveElement(input, 99), 7);
            int[] exp = new int[] { 1, 3, 5, 6, 6, 8, 102 };


            var output = input.ToList();
            output.RemoveRange(7 - 1, input.Length - 7);






            input = new int[] { 1, 3, 6, 2, 6, 8, 6, 99, 99, 102 };
            Assert.AreEqual(new Leet027_Remove_Element().RemoveElement(input, 6), 7);
            exp = new int[] { 1, 3, 2, 8, 99, 99, 102 };


            output = input.ToList();
            output.RemoveRange(7 - 1, input.Length - 7);


            CollectionAssert.AreEqual(output, exp);
        }
    }
}