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
    public class Leet049_Group_Anagrams_Tests
    {
        [TestMethod()]
        public void groupAnagrams_Test()
        {
            var res = Leet049_Group_Anagrams.groupAnagrams(
                new List<string> { "eat", "tea", "tan", "ate", "nat", "bat" });

            var exp = new List<List<string>> {
                new List<string>{ "ate", "eat","tea" },
                new List<string>{ "nat","tan" },
                new List<string>{ "bat" }
            };

            ColOp<string>.AreEqual(res, exp);


            res = Leet049_Group_Anagrams.groupAnagrams2(
                new List<string> { "eat", "tea", "tan", "ate", "nat", "bat" });

            ColOp<string>.AreEqual(res, exp);
        }
    }
}