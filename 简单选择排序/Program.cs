using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单选择排序
{
    class Program
    {
        static void SelectSort(int[] dataArray)
        {
            for (int i = 0; i < dataArray.Length-1; i++)
            {
                int min = dataArray[i];

                int minIndex = i;

                for (int j = i + 1; j < dataArray.Length; j++)
                {
                    if (dataArray[j] < min)
                    {
                        min = dataArray[j];

                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = dataArray[i];

                    dataArray[i] = dataArray[minIndex];

                    dataArray[minIndex] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] data = new int[] { 14, 464, 214, 4767, 124, 38, 54, 57 };

            SelectSort(data);

            foreach (var temp in data)
            {
                Console.Write(temp + " ");
            }

            Console.ReadKey();
        }
    }
}
