using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet052_NQueen_II
    {
        // http://www.cnblogs.com/jcliBlogger/p/4614716.html

        public static int totalNQueensII(int n)
        {
            int counts = 0;
            int limit = (1 << n) - 1;
            solve(0, 0, 0, limit, ref counts);
            return counts;
        }


        static void solve(int hProj, int lProj, int rProj, int limit, ref int counts)
        {
            if (hProj == limit)
            {
                counts++;
                return;
            }
            int pos = limit & (~(hProj | lProj | rProj));
            while (pos != 0)
            {
                int p = pos & (-pos);
                pos ^= p;
                solve(hProj | p, (lProj | p) << 1, (rProj | p) >> 1, limit, ref counts);
            }
        }

        public static int totalNQueensII2(int n)
        {
            int[] colPos = new int[n];
            int counts = 0;
            solve(colPos, n, 0, ref counts);
            return counts;
        }

        static bool noAttack(int[] colPos, int row, int col)
        {
            for (int r = row - 1, ld = col - 1, rd = col + 1; r >= 0; r--, ld--, rd++)
                if (colPos[r] == col || colPos[r] == ld || colPos[r] == rd)
                    return false;
            return true;
        }

        static void solve(int[] colPos, int n, int row, ref int counts)
        {
            if (row == n)
            {
                counts++;
                return;
            }
            for (int col = 0; col < n; col++)
            {
                colPos[row] = col;
                if (noAttack(colPos, row, col))
                    solve(colPos, n, row + 1, ref counts);
            }
        }


        public static int totalNQueensII3(int n)
        {
            int[] colPos = new int[n];
            //memset(colPos, -1, n * sizeof(int));
            colPos = Enumerable.Repeat(-1, n).ToArray();

            int row = 0, counts = 0;
            while (row >= 0)
            {
                if (row == n)
                {
                    counts++;
                    row--;
                }
                int col = (colPos[row] == -1) ? 0 : colPos[row] + 1;
                for (; col < n; col++)
                {
                    if (noAttack3(colPos, row, col))
                    {
                        colPos[row] = col;
                        row++;
                        break;
                    }
                }
                if (col == n)
                {
                    colPos[row] = -1;
                    row--;
                }
            }
            return counts;
        }

        static bool noAttack3(int[] colPos, int row, int col)
        {
            for (int r = row - 1, ld = col - 1, rd = col + 1; r >= 0; r--, ld--, rd++)
                if (colPos[r] == col || colPos[r] == ld || colPos[r] == rd)
                    return false;
            return true;
        }


    }

}
