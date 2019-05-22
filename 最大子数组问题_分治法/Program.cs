using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最大子数组问题_分治法
{
    class Program
    {
        struct SubArray
        {
            public int startIndex;

            public int endIndex;

            public int total;
        }

        static void Main(string[] args)
        {
            int[] priceArray = { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97 };

            int[] pf = new int[priceArray.Length - 1];

            for (int i = 1; i < priceArray.Length; i++)
            {
                pf[i - 1] = priceArray[i] - priceArray[i - 1];
            }

            SubArray subArray = GetMaxArray(0, pf.Length - 1, pf);

            Console.WriteLine(subArray.startIndex);

            Console.WriteLine(subArray.endIndex);

            Console.WriteLine("在第" + subArray.startIndex + "天买入，在第" + (subArray.endIndex + 1) + "天卖出");

            Console.ReadKey();
        }

        static SubArray GetMaxArray(int low, int high, int[] array)
        {
            if (low == high)
            {
                SubArray subArray;

                subArray.startIndex = low;

                subArray.endIndex = high;

                subArray.total = array[low];

                return subArray;
            }

            int mid = (low + high) / 2;

            SubArray subArray1 = GetMaxArray(low, mid, array);

            SubArray subArray2 = GetMaxArray(mid + 1, high, array);

            int total1 = array[mid];

            int startIndex = mid;

            int totalTemp = 0;

            for (int i = mid; i >= low; i--)
            {
                totalTemp += array[i];

                if (totalTemp > total1)
                {
                    total1 = totalTemp;

                    startIndex = i;
                }
            }

            int total2 = array[mid + 1];
            int endIndex = mid + 1;

            totalTemp = 0;

            for (int j = mid + 1; j <= high; j++)
            {
                totalTemp += array[j];

                if (totalTemp > total2)
                {
                    total2 = totalTemp;

                    endIndex = j;
                }
            }

            SubArray subArray3;

            subArray3.startIndex = startIndex;

            subArray3.endIndex = endIndex;

            subArray3.total = total1 + total2;

            if (subArray1.total >= subArray2.total && subArray1.total > subArray3.total)
            {
                return subArray1;
            }
            else if (subArray2.total >= subArray1.total && subArray2.total > subArray3.total)
            {
                return subArray2;
            }
            else
            {
                return subArray3;
            }
        }
    }
}
