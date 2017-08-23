using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSampleCode.Digit
{
    class Search
    {

        static void RunBinSearchSample()
        {
            int[] c = new int[] { 2, 3, 5, 6, 23, 66, 99, 102, 166, 199, 244 };
            int k = 99;

            int pos = BinarySearch(c, 0, c.Length -1, k);

        }
        public static int BinarySearch(int[] arr, int low, int high, int key)
        {
            int mid = (low + high) / 2;
            if (low > high)
                return -1;
            else
            {
                if (arr[mid] == key)
                    return mid;
                else if (arr[mid] > key)
                    return BinarySearch(arr, low, mid - 1, key);
                else
                    return BinarySearch(arr, mid + 1, high, key);
            }
        }

        public static int BinarySearchNoRecursive(int[] a, int low, int high, int key)
        {
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (key == a[mid])
                {
                    return mid;  //返回找到的索引值  
                }
                else
                {
                    if (key < a[mid])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
            }
            return -1; //查找失败  
        }


    }
}
