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
    public class Leet086_Partition_List_Tests
    {
        [TestMethod()]
        public void partition_Test()
        {
            ListNode list = new ListNode(new int[] { 9, 3, 1, 8, 2, 6, 4 });
            ListNode exp = new ListNode(new int[] { 3,1,2,4,9,8,6 });
            ListNode res = Leet086_Partition_List.partition(list, 5);
            Assert.AreEqual(res, exp);
        }
    }
}