using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet051_NQueens
    {

        // 逐行求解N-Queen问题  
        // 在每一行上，尝试每一个可能的列的位置  
        public static void solveNQueensUtil(int n, int row, List<string> sol, List<List<string>> sols)
        {
            if (row == n)
            {
                List<string> copy = new List<string>(sol);
                sols.Add(copy);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                //string str(n,'.');
                char[] arr = Enumerable.Repeat('.', n).ToArray();

                arr[i] = 'Q';
                string str = new string(arr);
                sol.Add(str);

                if (isValid(sol, row, i))
                {
                    solveNQueensUtil(n, row + 1, sol, sols);
                }
                //sol.pop_back();   c++
                sol.RemoveAt(sol.Count - 1);
                //sol.Remove(str);
            }
        }

        static bool isValid(List<string> cur, int row, int col)
        {
            int count = 0;

            // 列  
            for (int i = 0; i <= row; i++)
            {
                if (cur[i][col] == 'Q')
                    count++;
                if (count > 1) return false;
            }

            count = 0;

            //右对角线  
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (cur[i][j] == 'Q')
                    count++;
                if (count > 1) return false;
            }

            count = 0;

            //左对角线  
            for (int i = row, j = col; i >= 0 && j < cur[0].Count(); i--, j++)
            {
                if (cur[i][j] == 'Q')
                    count++;
                if (count > 1) return false;
            }

            return true;
        }
    }
}
