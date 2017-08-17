using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet079_Word_Search
    {
        public bool Exist(char[,] board, string word)
        {
            if (board != null && !string.IsNullOrEmpty(word))
            {
                int m = board.GetLength(0);
                int n = board.GetLength(1);
                if (m > 0 && n > 0)
                {
                    int[,] used = new int[m, n];
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (board[i, j] == word[0])
                            {
                                used[i, j] = 1;
                                bool found = isExist(board, word, i, j, 1, used, new List<char> { word[0] });
                                if (found)
                                    return true;
                                used[i, j] = 0;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private bool isExist(char[,] board, string word, int curI, int curJ, int index, int[,] used, List<char> l)
        {
            //Console.WriteLine(new string(l.ToArray<char>()));

            if (index == word.Length)
            {
                //Console.WriteLine("found");
                return true;
            }

            int m = board.GetLength(0);
            int n = board.GetLength(1);
            bool found = false;

            if (curI > 0 && used[curI - 1, curJ] == 0 && board[curI - 1, curJ] == word[index])
            {
                used[curI - 1, curJ] = 1;
                l.Add(word[index]);
                found = isExist(board, word, curI - 1, curJ, index + 1, used, l);
                l.Remove(word[index]);
                used[curI - 1, curJ] = 0;
            }

            if (found)
                return found;

            if (curJ + 1 < n && used[curI, curJ + 1] == 0 && board[curI, curJ + 1] == word[index])
            {
                used[curI, curJ + 1] = 1;
                l.Add(word[index]);
                found = isExist(board, word, curI, curJ + 1, index + 1, used, l);
                l.Remove(word[index]);
                used[curI, curJ + 1] = 0;
            }
            if (found)
                return found;

            if (curI + 1 < m && used[curI + 1, curJ] == 0 && board[curI + 1, curJ] == word[index])
            {
                used[curI + 1, curJ] = 1;
                l.Add(word[index]);
                found = isExist(board, word, curI + 1, curJ, index + 1, used, l);
                l.Remove(word[index]);
                used[curI + 1, curJ] = 0;
            }
            if (found)
                return found;

            if (curJ > 0 && used[curI, curJ - 1] == 0 && board[curI, curJ - 1] == word[index])
            {
                used[curI, curJ - 1] = 1;
                l.Add(word[index]);
                found = isExist(board, word, curI, curJ - 1, index + 1, used, l);
                l.Remove(word[index]);
                used[curI, curJ - 1] = 0;
            }

            return found;

        }
    }
}
