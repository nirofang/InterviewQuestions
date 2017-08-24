using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet036_Valid_Sudoku
    {
        public bool isValidSudoku(char[,] board)
        {
            int[] row = new int[9];
            int[] col = new int[9];
            int[] sqr = new int[9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i,j] != '.')
                    {
                        int num = board[i,j] - '0';
                        if ((row[i] & 1 << num) > 0)    // already in row
                        {
                            return false;
                        }
                        else
                        {
                            row[i] |= 1 << num;
                        }

                        if((col[j] & 1 << num) > 0)     // already in col
                        {
                            return false;
                        }
                        else
                        {
                            row[j] |= 1 << num;
                        }

                        int sqrIdx = (i - i % 3) + j / 3;

                        if ((sqr[sqrIdx] & 1 << num) > 0)
                        {
                            return false;
                        }
                        else
                        {
                            sqr[sqrIdx] |= 1 << num;
                        }


                    }
                }
            }

            return true;
        }
    }
}
