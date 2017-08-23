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
            var result = new Leet030_Substring_with_Concatenation_of_All_Words().FindSubstring("barfoothefoobarman", new string[] { "foo", "bar" });
            CollectionAssert.AreEqual(result.ToArray(), new int[] { 0, 9 });


            // Got the limitation that substring length should be the same = 2
            result = new Leet030_Substring_with_Concatenation_of_All_Words().FindSubstring("helloknifeworldhelloworld", new string[] { "hello", "world" });
            CollectionAssert.AreEqual(result.ToArray(), new int[] { 10, 15});


        }
    }
}