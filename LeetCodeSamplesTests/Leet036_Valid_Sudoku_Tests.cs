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
    public class Leet036_Valid_Sudoku_Tests
    {
        [TestMethod()]
        public void isValidSudoku_Test()
        {
            //char[][] board = new char[9][];
            char[,] board = new char[9, 9];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        board[i, j] = '.';
                    }
                    if (i == 0 && j != 0)
                    {
                        board[i, j] = (char)('0' + j + 1);
                    }
                    else
                    {
                        board[i, j] = '.';
                    }
                }
            }

            Assert.IsTrue(new Leet036_Valid_Sudoku().isValidSudoku(board));

        }
    }
}