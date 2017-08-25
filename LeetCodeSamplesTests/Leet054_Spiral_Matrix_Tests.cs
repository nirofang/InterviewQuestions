using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamplesTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamplesTests.Tests
{
    [TestClass()]
    public class Leet054_Spiral_Matrix_Tests
    {
        [TestMethod()]
        public void SpiralOrder_Test()
        {
            var matrix = new int[,] { { 1, 2, 3 }, { 8, 9, 4 }, { 7, 6, 5 } };
            var result = new Leet054_Spiral_Matrix().SpiralOrder(matrix);
            CollectionAssert.AreEqual(result.ToArray(), new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            var matrix2 = new int[][] { new int[]{ 1, 2, 3 }, new int[]{ 8, 9, 4 }, new int[] { 7, 6, 5 } };
            result = new Leet054_Spiral_Matrix().spiralOrder2(matrix2);
            CollectionAssert.AreEqual(result.ToArray(), new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        }
    }
}