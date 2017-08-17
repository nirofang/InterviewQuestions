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
    public class Leet030_Substring_with_Concatenation_of_All_Words_Tests
    {
        [TestMethod()]
        public void FindSubstring_Test()
        {

            // Got the limitation that substring length should be the same = 2
            var result = new Leet030_Substring_with_Concatenation_of_All_Words().FindSubstring("hello world", new string[] { "el", "o " });
            CollectionAssert.AreEqual(result.ToArray(), new int[] { 1, 4});


            // if substring[1].length != substring[0].length, only first index will return.
            result = new Leet030_Substring_with_Concatenation_of_All_Words().FindSubstring("hello world", new string[] { "el", "o w" });
            CollectionAssert.AreEqual(result.ToArray(), new int[] { 1 });

        }
    }
}