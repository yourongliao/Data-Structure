using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 堆排序_顺序存储
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 50, 10, 90, 30, 70, 40, 80, 60, 20 };

            HeapSort(data);

            foreach (int i in data)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.ReadKey();
        }

        public static void HeapSort(int[] data)
        {
            for (int i = data.Length / 2; i >= 1; i--)
            {
                HeapAjust(i, data, data.Length);
            }

            for (int i = data.Length; i > 1; i--)
            {
                int temp1 = data[0];

                data[0] = data[i - 1];

                data[i - 1] = temp1;

                HeapAjust(1, data, i - 1);
            }
        }

        public static void HeapAjust(int numberToAjust, int[] data, int maxNumber)
        {
            int maxNodeNumber = numberToAjust;

            int tempI = numberToAjust;

            while (true)
            {
                int leftChildNumber = tempI * 2;

                int rightChildNumber = leftChildNumber + 1;

                if (leftChildNumber <= maxNumber  && data[leftChildNumber - 1] > data[maxNodeNumber - 1])
                {
                    maxNodeNumber = leftChildNumber;
                }

                if (rightChildNumber <= maxNumber && data[rightChildNumber - 1] > data[maxNodeNumber - 1])
                {
                    maxNodeNumber = rightChildNumber;
                }

                if (maxNodeNumber != tempI)
                {
                    int temp = data[tempI - 1];

                    data[tempI - 1] = data[maxNodeNumber - 1];

                    data[maxNodeNumber - 1] = temp;

                    tempI = maxNodeNumber;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
