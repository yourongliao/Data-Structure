using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 栈
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<char> stack = new Stack<char>();

            //IStackDS<char> stack = new SeqStack<char>(30);

            IStackDS<char> stack = new LinkStack<char>();

            stack.Push('a');

            stack.Push('b');

            stack.Push('c');

            Console.WriteLine("push a b c 之后的数据个数为：" + stack.Count);

            char temp = stack.Pop();

            Console.WriteLine("pop之后得到的数据是：" + temp);

            Console.WriteLine("pop之后，栈中数据的个数是：" + stack.Count);

            char temp2 = stack.Peek();

            Console.WriteLine("peek之后得到的数据是：" + temp2);

            Console.WriteLine("peek之后，栈中数据的个数是：" + stack.Count);

            

            stack.Clear();

            Console.WriteLine("clear之后栈中数据的个数：" + stack.Count);

            Console.ReadKey();
        }
    }
}
