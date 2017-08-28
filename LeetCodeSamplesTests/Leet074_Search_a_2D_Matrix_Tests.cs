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
    public class Leet074_Search_a_2D_Matrix_Tests
    {
        [TestMethod()]
        public void SearchMatrix_Test()
        {
            int[,] input = new int[,] { { 1, 3, 5, 7 }, { 11, 18, 19, 22 }, { 84, 103, 255, 996 } };
            Assert.IsTrue(new Leet074_Search_a_2D_Matrix().SearchMatrix(input, 103));

            Assert.IsFalse(new Leet074_Search_a_2D_Matrix().SearchMatrix(input, 9));

            List<List<int>> lists = new List<List<int>>();
            for (int i = 0; i < input.GetLength(0); i++)
            {
                List<int> list = new List<int>();
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    list.Add(input[i, j]);
                }
                lists.Add(list);
            }


            Assert.IsTrue(Leet074_Search_a_2D_Matrix.searchMatrix1(lists, 103));

            Assert.IsTrue(Leet074_Search_a_2D_Matrix.searchMatrix2(lists, 103));

        }

    }
}