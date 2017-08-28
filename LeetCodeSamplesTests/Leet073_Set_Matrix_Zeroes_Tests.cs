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
    public class Leet073_Set_Matrix_Zeroes_Tests
    {
        [TestMethod()]
        public void SetZeroes_Test()
        {
            int[,] input = new int[,] { { 1, 3, 2 , 6 }, { 1, 0, 5, 6 }, { 0, 3, 5, 6 } };
            new Leet073_Set_Matrix_Zeroes().SetZeroes(input);
            CollectionAssert.AreEqual(input, new int[,] { { 0 , 0, 2, 6 },{ 0, 0, 0,0},{ 0, 0, 0,0 } });

            int[][] input2 = new int[][] { new int[] { 1, 3, 2, 6 }, new int[] { 1, 0, 5, 6 }, new int[] { 0, 3, 5, 6 } };
            Leet073_Set_Matrix_Zeroes.setZeroes2(input2);
            CollectionAssert.AreEqual(input, new int[,] { { 0, 0, 2, 6 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } });
        }
    }
}