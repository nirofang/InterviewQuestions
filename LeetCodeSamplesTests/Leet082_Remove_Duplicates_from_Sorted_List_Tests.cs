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
    public class Leet082_Remove_Duplicates_from_Sorted_List_Tests
    {
        [TestMethod()]
        public void deleteDuplicates_Test()
        {
            ListNode list = new ListNode(new int[] { 1, 3, 3, 8, 8,8,8, 9, 9, 9, 10 });
            ListNode exp = new ListNode(new int[] { 1, 3, 8, 9, 10 });

            ListNode res = Leet082_Remove_Duplicates_from_Sorted_List.deleteDuplicates(list);
            Assert.AreEqual(res, exp);
        }
    }
}