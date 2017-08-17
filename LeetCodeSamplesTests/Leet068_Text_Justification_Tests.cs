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
    public class Leet068_Text_Justification_Tests
    {
        [TestMethod()]
        public void FullJustify_Test()
        {
            var result = new Leet068_Text_Justification().FullJustify(
                new string[] { "This", "is", "an", "example", "of", "text", "justification." }, 16);

            CollectionAssert.AreEqual(result.ToArray(), new string[] { "This    is    an", "example  of text", "justification.  " });
        }
    }
}