using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet119_Pascals_Triangle_II
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> list = new List<int>();
            if (rowIndex == 0)
            {
                list.Add(1);
            }
            else if (rowIndex == 1)
            {
                list.Add(1);
                list.Add(1);
            }
            else if (rowIndex > 1)
            {
                int[] nums = new int[rowIndex + 1];
                nums[0] = 1;
                nums[1] = 1;
                for (int i = 2; i <= rowIndex; i++)
                {
                    nums[i] = 1;
                    for (int j = i - 1; j > 0; j--)
                    {
                        nums[j] = nums[j - 1] + nums[j];
                    }
                }
                list = nums.ToList<int>();
            }
            return list;
        }
    }
}
