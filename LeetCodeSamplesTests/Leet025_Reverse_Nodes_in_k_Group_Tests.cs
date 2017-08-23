using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamplesTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSamples.DataStruct;

namespace LeetCodeSamplesTests.Tests
{
    [TestClass()]
    public class Leet025_Reverse_Nodes_in_k_Group_Tests
    {
        [TestMethod()]
        public void ReverseKGroup_Test()
        {
            ListNode input = new ListNode(new int[] { 1, 3, 8, 9, 10, 12, 15, 20 });
            ListNode exp = new ListNode(new int[] { 8, 3, 1, 12, 10, 9, 15, 20 });
            Assert.AreEqual(exp, new Leet025_Reverse_Nodes_in_k_Group().ReverseKGroup(input, 3));
        }
    }
}