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


        public int RemoveDuplicates_Own_Standard(int[] nums)
        {
            int count = 0;
            int len = nums.Length;
            for (int i= 0; i< len; i++)
            {
                // Too trtick
                if (count == 0 || nums[i] != nums[count - 1])
                {
                    nums[count++] = nums[i];
                }
            }

            return count;
        }

        public int RemoveDuplicates_Own_Standard_Simple(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return 1;
            }


            int count = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                
                if (nums[i] != nums[count-1])
                {
                    if (count == i)
                    {
                        count++;
                        continue;
                    }
                    nums[count++] = nums[i];
                }
            }

            return count;
        }

        public int RemoveDuplicates_Own_2Pointers(int[] nums)
        {
            int i = 0;
            int j = 0;
            int pos = i + 1;
            while (i < nums.Length)
            {
                j = i + 1;
                while(j<nums.Length && nums[i]==nums[j])
                {
                    j++;
                }
                if (j >= nums.Length) break;
                nums[pos] = nums[j];
                pos++;
                i = j;
            }
            return pos;
        }
        

    }
}
