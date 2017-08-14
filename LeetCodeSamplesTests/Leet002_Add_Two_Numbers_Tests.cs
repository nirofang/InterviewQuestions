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
    public class Leet001_Add_Two_Numbers_Tests
    {
        [TestMethod()]
        public void Add_Two_Numbers_Link_SingleNode_Test()
        {
            ListNode a = new ListNode(5);
            ListNode b = new ListNode(3);
            ListNode c = new ListNode(8);
            ListNode result = new Leet002_Add_Two_Numbers().Add_Two_Numbers(a, b);
            Assert.AreEqual(result, c);
        }


        [TestMethod()]
        public void Add_Two_Numbers_Link_List_Test()
        {
            ListNode a = new ListNode(new int[] { 1, 2, 3 });
            ListNode b = new ListNode(new int[] { 4, 5, 6 });
            ListNode c = new ListNode(new int[] { 5, 7, 9 });
            ListNode result = new Leet002_Add_Two_Numbers().Add_Two_Numbers(a, b);
            
            Assert.AreEqual(result, c);



            a.AddTail(new ListNode(new int[] { 1, 2, 3 }));
            b.AddTail(new ListNode(new int[] { 4, 5, 6 }));
            ListNode newc = new ListNode(new int[] { 5, 7, 9, 5, 7, 9 });

            result = new Leet002_Add_Two_Numbers().Add_Two_Numbers(a, b);
            Assert.AreEqual(result, newc);



            result = new Leet002_Add_Two_Numbers().Add_Two_Numbers(a, b);
            Assert.AreEqual(result, newc);


            // 1,2,3,1,2,3 + 5,7,9,5,7,9 = 6,9,2,7,9,2,1
            result = new Leet002_Add_Two_Numbers().Add_Two_Numbers(a, newc);
            ListNode newac = new ListNode(new int[] { 6, 9, 2, 7, 9, 2, 1 });
            Assert.AreEqual(result, newac);


            ListNode result_self = new Leet002_Add_Two_Numbers().Add_Two_Numbers_Self(a, b);

            Assert.AreEqual(result_self, newc);

            result_self = new Leet002_Add_Two_Numbers().Add_Two_Numbers_Self(a, newc);
            Assert.AreEqual(result_self, newac);
        }
    }
}