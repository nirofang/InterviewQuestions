﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet004_Median_of_Two_Sorted_Arrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0 || nums2 == null || nums2.Length == 0)
            {
                if ((nums1 == null || nums1.Length == 0) && (nums2 != null && nums2.Length > 0))
                {
                    if ((nums2.Length & 0x1) == 0x1)
                    {
                        return nums2[nums2.Length / 2];
                    }
                    else
                    {
                        return (nums2[nums2.Length / 2] + nums2[nums2.Length / 2 - 1]) / 2.0;
                    }
                }
                else if ((nums1 != null && nums1.Length > 0) && (nums2 == null || nums2.Length == 0))
                {
                    if ((nums1.Length & 0x1) == 0x1)
                    {
                        return nums1[nums1.Length / 2];
                    }
                    else
                    {
                        return (nums1[nums1.Length / 2] + nums1[nums1.Length / 2 - 1]) / 2.0;
                    }
                }
                else
                {
                    return 0.0;
                }
            }

            int length = nums1.Length + nums2.Length;

            if ((length & 0x1) == 0x1)
            {
                return getNumber(nums1, nums2, 0, nums1.Length - 1, 0, nums2.Length - 1, length / 2 + 1);
            }
            else
            {
                System.Console.Write(getNumber(nums1, nums2, 0, nums1.Length - 1, 0, nums2.Length - 1, length / 2));
                System.Console.Write(getNumber(nums1, nums2, 0, nums1.Length - 1, 0, nums2.Length - 1, length / 2 + 1));
                return (getNumber(nums1, nums2, 0, nums1.Length - 1, 0, nums2.Length - 1, length / 2) + getNumber(nums1, nums2, 0, nums1.Length - 1, 0, nums2.Length - 1, length / 2 + 1)) / 2.0;
            }

            return 0.0;
        }

        private int getNumber(int[] nums1, int[] nums2, int start1, int end1, int start2, int end2, int n)
        {
            if (end1 - start1 > end2 - start2)
            {
                return getNumber(nums2, nums1, start2, end2, start1, end1, n);
            }

            if (end1 < start1)
            {
                return nums2[start2 + n - 1];
            }
            if (end2 < start2)
            {
                return nums1[start1 + n - 1];
            }

            if (n == 1)
            {
                return Math.Min(nums1[start1], nums2[start2]);
            }

            int pa = Math.Min(end1 - start1 + 1, n / 2);
            int pb = n - pa;

            if (nums1[start1 + pa - 1] == nums2[start2 + pb - 1])
            {
                return nums1[start1 + pa - 1];
            }
            else if (nums1[start1 + pa - 1] > nums2[start2 + pb - 1])
            {
                return getNumber(nums1, nums2, start1, end1, start2 + pb, end2, n - pb);
            }
            else
            {
                return getNumber(nums1, nums2, start1 + pa, end1, start2, end2, n - pa);
            }
        }
    }

}
