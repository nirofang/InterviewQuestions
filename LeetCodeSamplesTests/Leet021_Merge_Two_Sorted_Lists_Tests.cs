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
    public class Leet021_Merge_Two_Sorted_Lists_Tests
    {
        [TestMethod()]
        public void MergeTwoLists_Test()
        {
            ListNode l1 = new ListNode(new int[] { 5, 7, 9 });
            ListNode l2 = new ListNode(new int[] { 1, 3, 8, 9, 10 });
            ListNode result = new ListNode(new int[] { 1, 3, 5, 7, 8, 9, 9, 10});
            Assert.AreEqual(result, new Leet021_Merge_Two_Sorted_Lists().MergeTwoLists(l1, l2));

            l1 = new ListNode(new int[] { 5, 7, 9 });
            l2 = new ListNode(new int[] { 1, 3, 8, 9, 10 });
            result = new ListNode(new int[] { 1, 3, 5, 7, 8, 9, 9, 10 });
            Assert.AreEqual(result, new Leet021_Merge_Two_Sorted_Lists().MergeTwoLists_Own(l1, l2));


            l1 = new ListNode(new int[] { 5, 7, 9 });
            l2 = new ListNode(new int[] { 1, 3, 8, 9, 10 });
            result = new ListNode(new int[] { 1, 3, 5, 7, 8, 9, 9, 10 });
            Assert.AreEqual(result, new Leet021_Merge_Two_Sorted_Lists().MergeTwoLists_Own2(l1, l2));

        }
    }
}