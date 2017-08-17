using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet032_Longest_Valid_Parentheses
    {
        public int LongestValidParentheses(string s)
        {
            int max = 0;
            if (!string.IsNullOrEmpty(s))
            {
                Stack<KeyValuePair<int, int>> stack = new Stack<KeyValuePair<int, int>>();
                int curLen = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                    {
                        stack.Push(new KeyValuePair<int, int>(i, 0));
                    }
                    else
                    {
                        if (stack.Count == 0 || stack.Peek().Value == 1)
                        {
                            stack.Push(new KeyValuePair<int, int>(i, 1));
                        }
                        else
                        {
                            stack.Pop();
                            if (stack.Count == 0)
                                curLen = i + 1;
                            else
                                curLen = i - stack.Peek().Key;
                            max = Math.Max(max, curLen);
                        }
                    }
                }
            }
            return max;
        }
    }
}
