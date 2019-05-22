using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 快速排序
{
    class Program
    {
        static void QuickSort(int[] dataArray, int left, int right)
        {
            if (left < right)
            {
                int x = dataArray[left];

                int i = left;

                int j = right;


                while (true&&i<j)
                {
                    while (true && i < j)
                    {
                        if (dataArray[j] <= x)
                        {
                            dataArray[i] = dataArray[j];
                            break;
                        }
                        else
                        {
                            j--;
                        }
                    }

                    while (true && i < j)
                    {
                        if (dataArray[i] > x)
                        {
                            dataArray[j] = dataArray[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }

                dataArray[i] = x;

                QuickSort(dataArray, left, i - 1);

                QuickSort(dataArray, i + 1, right);
            }
        }

        static void Main(string[] args)
        {

            int[] data = new int[] { 14, 6464, 244, 3, 4646, 14, 4677, 34, 2, 7 };

            QuickSort(data, 0, data.Length - 1);

            foreach (var temp in data)
            {
                Console.Write(temp + " ");
            }

            Console.ReadKey();
        }
    }
}
