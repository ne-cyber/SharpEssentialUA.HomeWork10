using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _02;

namespace _04
{

    static class ExtClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] arr = new T[list.Count];

            //Array.Copy(list, arr, Lenght);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = list[i];
            }

            return arr;
        }

    }



    internal partial class Program
    {

        static void Main(string[] args)
        {

            MyList<int> myList = new MyList<int>();
            myList.Add(0);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            int[] arr = myList.GetArray();

            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0} ", arr[i]);

            Console.WriteLine();





            Console.ReadKey();
        }
    }








}
