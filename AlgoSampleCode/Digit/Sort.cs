using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSampleCode.Digit
{
    public class Sort
    {
        static void RunSample()
        {
            int[] arr = new int[] { 54, 62, 99, 14, 28, 1, 8, 77, 99, 3, 110 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.Write("Data After QuickSort:");
            foreach (int i in arr)
            {
                Console.Write(i + ",");
            }
            Console.ReadLine();

        }

        static int partion(int[] data, int low, int high)
        {
            int i = low;
            int j = high;
            int pivot = data[low];

            while (i < j)
            {
                while (i < j && data[j] >= pivot)
                    j--;
                if (i < j)
                    data[i++] = data[j];

                while (i < j && data[i] <= pivot)
                    i++;

                if (i < j)
                    data[j--] = data[i];
            }
            data[i] = pivot;
            return i;
        }

        static void QuickSort(int[] data, int low, int high)
        {
            int pivot;

            if (low < high)
            {
                pivot = partion(data, low, high);
                QuickSort(data, low, pivot - 1);
                QuickSort(data, pivot + 1, high);
            }
        }

    }
}
