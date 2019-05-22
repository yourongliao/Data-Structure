using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 队列
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue<int> queue = new Queue<int>();
            //SeqQueue<int> queue = new SeqQueue<int>();
            LinkQueue<int> queue = new LinkQueue<int>();

            queue.Enqueue(23);
            queue.Enqueue(53);
            queue.Enqueue(78);
            queue.Enqueue(41);

            Console.WriteLine("添加了数字之后，队列大小为:" + queue.Count);

            int i = queue.Dequeue();

            Console.WriteLine("取得队首的数据为：" + i);

            Console.WriteLine("出队之后，队列大小为：" + queue.Count);

            int j = queue.Peek();

            Console.WriteLine("peek得到的结果是：" + j);

            Console.WriteLine("Peek之后队列的大小为：" + queue.Count);

            queue.Clear();

            Console.WriteLine("clear之后队列的大小为：" + queue.Count);

            Console.ReadKey();
        }
    }
}
