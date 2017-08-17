using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet084_Largest_Rectangle_in_Histogram
    {
        public int LargestRectangleArea(int[] heights)
        {
            int max = 0;
            if (heights != null && heights.Length > 0)
            {
                Stack<int> stack = new Stack<int>();
                stack.Push(0);
                for (int i = 1; i <= heights.Length; i++)
                {
                    int height = i == heights.Length ? -1 : heights[i];
                    while (stack.Count > 0 && height < heights[stack.Peek()])
                    {
                        int index = stack.Pop();
                        int h = heights[index];
                        int w = stack.Count == 0 ? i : i - stack.Peek() - 1;
                        max = Math.Max(max, h * w);
                    }
                    stack.Push(i);
                }
            }
            return max;
        }
    }
}
