using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal partial class Program
    {     


        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();

            list.Add("first item");
            list.Add("second item");
            list.Add("third item");

            Console.WriteLine("items count: " + list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ": " + list[i]);
            }

            Console.WriteLine(new string('-', 30));









            List<string> list2 = new List<string>();

            list2.Add("first item");
            list2.Add("second item");
            list2.Add("third item");

            Console.WriteLine("items count: " + list2.Count);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ": " + list[i]);
            }

            Console.ReadKey();
        }
    }
}
