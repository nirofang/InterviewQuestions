using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSamples.Util;

namespace LeetCodeSamples.Tests
{
    [TestClass()]
    public class Leet051_NQueens_Tests
    {
        [TestMethod()]
        public void solveNQueensUtil_Test()
        {
            List<List<string>> board = new List<List<string>>();
            List<string> sol = new List<string>();

            Leet051_NQueens.solveNQueensUtil(4, 0, sol, board);

            var exp = new List<List<string>>{new List<string>{
                    ".Q..",  // Solution 1
                    "...Q",
                    "Q...",
                    "..Q."},
                    new List<string>{
                    "..Q.",  // Solution 2
                    "Q...",
                    "...Q",
                    ".Q.."}
            };
            ColOp<string>.AreEqual(exp, board);
        }

    }
}