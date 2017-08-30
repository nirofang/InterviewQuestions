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
    public class Leet023_Merge_k_Sorted_Lists_Tests
    {
        [TestMethod()]
        public void mergeKLists_Test()
        {
            List<ListNode> list = new List<ListNode> {
                new ListNode(new int[] { 1, 6 }),
                new ListNode(new int[] { 3, 4, 8 }),
                new ListNode(new int[] { 2, 5, 13 })
            };
            ListNode exp = new ListNode(new int[] { 1,2, 3, 4, 5, 6, 8, 13 });

            https://github.com/patrickuhlmann/Stuff/blob/master/C%23%20Code/Blog/Priority%20Queue/PriorityQueue.cs
            http://blog.csdn.net/yefengzhichen/article/details/47153657

            ListNode res = Leet023_Merge_k_Sorted_Lists.mergeKLists(list);
            Assert.AreEqual(res, exp);

            list = new List<ListNode> {
                new ListNode(new int[] { 1, 6 }),
                new ListNode(new int[] { 3, 4, 8 }),
                new ListNode(new int[] { 2, 5, 13 })
            };
            res = Leet023_Merge_k_Sorted_Lists.mergeKLists2(list);
            Assert.AreEqual(res, exp);
        }
    }
}