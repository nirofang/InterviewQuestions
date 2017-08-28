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

        // http://blog.csdn.net/yzhang6_10/article/details/50988210

        // 交换两个数函数   
        static void swap(List<int> nums, int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
        //直观理解   
        public static void sortColors1(List<int> nums)
        {
            int len = nums.Count;
            if (len <= 1)
                return;
            int i = 0;
            int j = len - 1;
            int cur = i;
            while (cur <= j)
            {
                // 当前指针指向值为0时，当前指针与指向第一个不确定为0的指针交换，同时向前移动连个指针   
                if (nums[cur] == 0)
                {
                    swap(nums, i++, cur++);
                }
                // 当前指针指向值为2时，当前指针与指向第一个不确定为2的指针交换，同时向前移动后面的指针   
                else if (nums[cur] == 2)
                {
                    if (cur < j)
                    {
                        swap(nums, j--, cur);
                    }
                    else
                        return;
                }
                // 当前指针指向值为0时，向前移动当前真真   
                else
                {
                    cur++;
                }
            }
        }

        public static void sortColors2(List<int> nums)
        {
            int zero_end = -1;
            int two_begin = nums.Count;
            int i = 0;
            while (i < two_begin)
            {
                if (nums[i] == 0 && i != ++zero_end)
                {
                    swap(nums, i, zero_end);
                }
                else if (nums[i] == 2 && i != --two_begin)
                {
                    swap(nums, i, two_begin);
                }
                else
                    i++;
            }
        }

    }
}
