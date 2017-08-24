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
    public class Leet035_Search_Insert_Position_Tests
    {
        [TestMethod()]
        public void searchInsert_Test()
        {
            int index = new Leet035_Search_Insert_Position().searchInsert(new int[] { 1, 3, 5, 6 }, 5);
            Assert.AreEqual(index, 2);


            index = new Leet035_Search_Insert_Position().searchInsert(new int[] { 1, 3, 5, 6 }, 2);
            Assert.AreEqual(index, 1);

            index = new Leet035_Search_Insert_Position().searchInsert(new int[] { 1, 3, 5, 6 }, 7);
            Assert.AreEqual(index, 4);

            index = new Leet035_Search_Insert_Position().searchInsert(new int[] { 1, 3, 5, 6 }, 0);
            Assert.AreEqual(index, 0);
        }
    }
}