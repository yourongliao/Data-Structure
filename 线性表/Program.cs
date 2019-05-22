using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<string> strList = new List<string>();

            //strList.Add("145");
            //strList.Add("12a");
            //strList.Add("3th");

            //Console.WriteLine(strList[1]);

            //strList.Remove("3th");

            //Console.WriteLine(strList.Count);

            //strList.Clear();

            //Console.WriteLine(strList.Count);

            //Console.ReadKey();

            //SeqList<string> seqList = new SeqList<string>();

            LinkList<string> seqList = new LinkList<string>();

            seqList.Add("144");

            seqList.Add("637d");

            seqList.Add("大发发");

            Console.WriteLine(seqList.GetEle(0));

            Console.WriteLine(seqList[0]);

            seqList.Insert("fafaf阿萨", 3);

            for (int i = 0; i < seqList.GetLength(); i++)
            {
                Console.Write(seqList[i] + " ");
            }

            Console.WriteLine();

            seqList.Delete(0);

            for (int i = 0; i < seqList.GetLength(); i++)
            {
                Console.Write(seqList[i] + " ");
            }

            Console.WriteLine();

            seqList.Clear();

            Console.WriteLine(seqList.GetLength());

            Console.ReadKey();
        }
    }
}
