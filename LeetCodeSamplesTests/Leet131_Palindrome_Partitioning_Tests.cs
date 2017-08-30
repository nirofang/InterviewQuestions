using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSamples.Util;

namespace LeetCodeSamples.Tests
{
    [TestClass()]
    public class Leet131_Palindrome_Partitioning_Tests
    {
        [TestMethod()]
        public void Partition_Test()
        {
            var exp = new List<List<string>> {
                new List<string> { "a", "a", "b" }, new List<string> { "aa", "b" } };

            var res = Leet131_Palindrome_Partitioning.Partition("aab");

            ColOp<string>.AreEqual(exp, res.Select(x=>x.ToList()).ToList());


        }
    }
}