using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet020_Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            Stack<Char> stack = new Stack<char>();

            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char c = stack.Pop();
                    if (s[i] == ')' && c != '(')
                    {
                        return false;
                    }
                    if (s[i] == ']' && c != '[')
                    {
                        return false;
                    }
                    if (s[i] == '}' && c != '{')
                    {
                        return false;
                    }
                }
            }

            if (stack.Count != 0)
            {
                return false;
            }

            return true;
        }
    }
}
