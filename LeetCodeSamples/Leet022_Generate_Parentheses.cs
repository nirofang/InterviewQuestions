using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet022_Generate_Parentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> list = new List<string>();
            if (n > 0)
            {
                generateParenthesis("", 0, 0, n, list);
            }
            return list;
        }

        private void generateParenthesis(string s, int index, int leftParenthesisNum, int n, IList<string> list)
        {
            if (index == 2 * n)
            {
                list.Add(s);
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0 && leftParenthesisNum < n)
                    {
                        generateParenthesis(s + "(", index + 1, leftParenthesisNum + 1, n, list);
                    }
                    else if (i == 1 && leftParenthesisNum > index / 2)
                    {
                        generateParenthesis(s + ")", index + 1, leftParenthesisNum, n, list);
                    }
                }
            }
        }

        public IList<string> GenerateParenthesis_Own(int n)
        {
            List<string> list = new List<string>();
            GenerateParenthesis_Own("", 0, 0, n, list);
            return list;
        }

        private void GenerateParenthesis_Own(string s, int left, int right, int pair, List<string> list)
        {
            if (left == pair && right == pair)
            {
                list.Add(s);
                return;
            }
            if (left < pair)
            {
                GenerateParenthesis_Own(s + "(", left + 1, right, pair, list);
            }
            if (right < left)
            {
                GenerateParenthesis_Own(s + ")", left, right+1, pair, list);
            }
        }
    }
}
