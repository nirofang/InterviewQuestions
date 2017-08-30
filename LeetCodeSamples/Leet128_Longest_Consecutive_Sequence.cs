using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet128_Longest_Consecutive_Sequence
    {
        public static int[] longestConsecutive(int[] input)
        {
            int maxlen = 0;
            HashSet<int> set = new HashSet<int>(input);
            List<int> output = new List<int>();
            int min = 0;
            int max = 0;
            for (int i = 0; i<input.Length; i++)
            {
                int num = input[i];
                int low = num - 1;
                int len = 0;
                while (set.Contains(low))
                {
                    low--;
                    len++;
                }
                low++;
                int high = num + 1;
                while (set.Contains(high))
                {
                    high++;
                    len++;
                }
                high--;
                if(len>maxlen)
                {
                    maxlen = len;
                    min = low;
                    max = high;
                }
            }
            for(int i = min; i <= max; i++)
            {
                output.Add(i);
            }
            return output.ToArray();
        }
    }
}
