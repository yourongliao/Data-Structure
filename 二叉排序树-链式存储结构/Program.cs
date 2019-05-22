using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉排序树_链式存储结构
{
    class Program
    {
        static void Main(string[] args)
        {

            BSTree tree = new BSTree();

            int[] data = { 251, 544, 35, 45, 24, 9, 35, 4, 75 };

            foreach (int t in data)
            {
                tree.Add(t);
            }


            tree.MiddleTraversal();

            Console.WriteLine();

            Console.WriteLine(tree.Find(99));

            Console.WriteLine(tree.Find(24));

            tree.Delete(544);


            tree.MiddleTraversal();

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
