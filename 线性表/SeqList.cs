using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
    class SeqList<T> : IListDS<T>
    {
        private T[] data;

        private int count = 0;

        public SeqList(int size)
        {
            data = new T[size];

            count = 0;
        }

        public SeqList() : this(10)
        {

        }

        public T this[int index]
        {
            get { return GetEle(index); }
        }

        public void Add(T item)
        {
            if (count == data.Length)
            {
                Console.WriteLine("当前顺序表已经存满，不允许继续存入");
            }
            else
            {
                data[count] = item;
                count++;
            }
        }

        public void Clear()
        {
            count = 0;
        }

        public T Delete(int index)
        {
            T temp = data[index];

            for (int i = index+1; i < count; i++)
            {
                data[i - 1] = data[i];
            }

            count--;

            return temp;
        }

        public T GetEle(int index)
        {
            if (index >= 0 && index <= count - 1)
            {
                return data[index];
            }
            else
            {
                Console.WriteLine("索引不存在");

                return default(T);
            }
        }

        public int GetLength()
        {
            return count;
        }

        public void Insert(T item, int index)
        {
            for (int i = count - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }

            data[index] = item;

            count++;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public int Locate(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
