using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoSampleCode.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSampleCode.Data.Tests
{
    [TestClass()]
    public class HeapMin_Tests
    {
        [TestMethod()]
        public void HeapMin_Test()
        {
            var heap = new HeapMin(6);

            var input = new int[] { 5, 3, 6, 9, 13, 10 };
            for (int i = 0; i < input.Length; i++)
            {
                heap.Insert(new HeapMin.Node(input[i], 0));
            }
        }

        [TestMethod()]
        public void IsFull_Test()
        {

        }

        [TestMethod()]
        public void IsEmpty_Test()
        {

        }

        [TestMethod()]
        public void FilerDown_Test()
        {
            var heap = new HeapMin(6);

            var input = new int[] { 6, 3, 5, 9, 13, 10 };
            for (int i = 0; i < input.Length; i++)
            {
                heap.Insert(new HeapMin.Node(input[i], 0));
            }
            var minIndex = heap.RemoveMin();
            Assert.AreEqual(0, minIndex);
            heap.FilerDown(0,  9);
        }

        [TestMethod()]
        public void FilerUp_Test()
        {

        }

        [TestMethod()]
        public void Insert_Test()
        {

        }

        [TestMethod()]
        public void RemoveMin_Test()
        {

        }

        [TestMethod()]
        public void MakeEmpty_Test()
        {

        }
    }
}