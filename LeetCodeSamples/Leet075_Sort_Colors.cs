using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet075_Sort_Colors
    {
        public void SortColors(int[] nums)
        {
            if (nums != null && nums.Length > 0)
            {
                int start = 0;
                int end = nums.Length - 1;

                while (start <= end && nums[start] == 0)
                    start++;
                while (start <= end && nums[end] == 2)
                    end--;
                if (start >= end)
                    return;
                int index = start;
                if (nums[start] == 0)
                    index++;
                while (index <= end)
                {
                    if (nums[index] == 1)
                        index++;
                    else if (nums[index] == 0)
                    {
                        int temp = nums[start];
                        nums[start] = 0;
                        nums[index] = temp;
                        while (start < end && nums[start] == 0)
                            start++;
                        if (start >= index)
                            index = start + 1;
                    }
                    else
                    {
                        int temp = nums[end];
                        nums[end] = 2;
                        nums[index] = temp;
                        while (start < end && nums[end] == 2)
                            end--;
                    }
                }

            }

        }
    }
}
