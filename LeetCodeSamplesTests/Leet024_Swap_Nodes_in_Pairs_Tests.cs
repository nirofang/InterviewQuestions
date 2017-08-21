using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSamples.DataStruct;

namespace LeetCodeSamples.Tests
{
    [TestClass()]
    public class Leet024_Swap_Nodes_in_Pairs_Tests
    {
        [TestMethod()]
        public void swapPairs_Test()
        {
            ListNode list1 = new ListNode(new int[] { 1, 2, 3, 4, 5, 6 });

            ListNode exp = new ListNode(new int[] { 2, 1, 4, 3, 6, 5 });

            var result = new Leet024_Swap_Nodes_in_Pairs().swapPairs(list1);
            Assert.AreEqual(result, exp);
                
        }
    }
}