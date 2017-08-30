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
    public class Leet083_Remove_Duplicates_from_Sorted_List_II_Tests
    {
        [TestMethod()]
        public void deleteDuplicates_Test()
        {
            ListNode list = new ListNode(new int[] { 1, 3, 3, 8, 8, 8, 8, 9, 9, 9, 10 });
            ListNode exp = new ListNode(new int[] { 1, 10 });
            var res = Leet083_Remove_Duplicates_from_Sorted_List_II.deleteDuplicates(list);
            Assert.AreEqual(res, exp);
        }
    }
}