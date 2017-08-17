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
    public class Leet059_Spiral_Matrix_II_Tests
    {
        [TestMethod()]
        public void GenerateMatrix_Test()
        {
            var result = new Leet059_Spiral_Matrix_II().GenerateMatrix(3);
            CollectionAssert.AreEqual(result, new int[,] { { 1, 2, 3 }, { 8, 9, 4 }, { 7, 6, 5 } });
        }
    }
}