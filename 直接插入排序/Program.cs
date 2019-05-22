using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 直接插入排序
{
    class Program
    {
        static void InsertSort(int[] dataArray)
        {
            for (int i = 1; i < dataArray.Length; i++)
            {
                int value = dataArray[i];

                bool isInsert = false;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (dataArray[j] > value)
                    {
                        dataArray[j + 1] = dataArray[j];
                    }
                    else
                    {
                        dataArray[j + 1] = value;

                        isInsert = true;

                        break;
                    }
                }

                if (isInsert == false)
                {
                    dataArray[0] = value;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] data = new int[] { 134, 94, 323, 46, 144, 3456, 351, 12, 4 };

            InsertSort(data);

            foreach (var temp in data)
            {
                Console.Write(temp + " ");
            }

            Console.ReadKey();
        }
    }
}
