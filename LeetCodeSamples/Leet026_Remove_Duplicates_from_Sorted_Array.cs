using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{

    public class Leet026_Remove_Duplicates_from_Sorted_Array
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums != null && nums.Length > 0)
            {
                int i = 1;
                while (i < nums.Length && nums[i - 1] != nums[i])
                    i++;
                int j = i + 1;
                while (j < nums.Length)
                {
                    while (j < nums.Length && nums[j] == nums[j - 1])
                        j++;
                    if (j < nums.Length)
                    {
                        nums[i] = nums[j];
                        i++;
                    }

                    j++;
                }
                return i;
            }
            return 0;
        }
    }
}
