using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 串
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDS s = new StringDS("I am isscuss");

            StringDS i = new StringDS("nice");

            StringDS r = new StringDS("student");

            StringDS a = new StringDS("iss");

            Console.WriteLine(s.GetLength());

            Console.WriteLine(i.GetLength());

            Console.WriteLine(r.GetLength());

            StringDS s2 = s.SubString(8, 4);

            Console.WriteLine(s2.ToString());

            StringDS s3 = i.SubString(2, 1);

            Console.WriteLine(s3.ToString());

           Console.WriteLine(s.IndexOf(a));

            Console.ReadKey();
        }
    }
}
