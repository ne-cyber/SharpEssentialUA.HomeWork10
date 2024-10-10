using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {

        //interface IMagicBear<T> where T : Creature
        //{
        //    Type CreatureType
        //    {
        //        get;
        //        set;
        //    }
        //}



        //class MagicBear<T> : IMagicBear<T> where T : Creature
        //{
        //    public Gift<T> Open()
        //    {

        //        TimeSpan timeSpan = DateTime.Now - lastTry;
        //        if (timeSpan.TotalDays >= 1)
        //        {
        //            lastTry = DateTime.Now;
        //            Console.WriteLine("В мішку дещо є! для {0}", typeof(T).Name);
        //            return new Gift<T>();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Зараз в мішку для {0} нічого немає", typeof(T).Name);
        //            return default(Gift<T>);
        //        }


        //    }

        //    public Type CreatureType
        //    {
        //        get { return typeof(T); }
        //        set { }
        //    }

        //    static DateTime lastTry;

        //    public MagicBear()
        //    {
        //        lastTry = DateTime.MinValue;
        //    }

        //}


        //class Gift<T>
        //{ }


        //abstract class Creature
        //{
        //}
        //class Human : Creature
        //{ }
        //class Elf : Creature
        //{ }


        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = Encoding.Unicode;
        //    Console.InputEncoding = Encoding.Unicode;

        //    MagicBear<Human> humanBear = new MagicBear<Human>();
        //    MagicBear<Elf> elfBear = new MagicBear<Elf>();

        //    Gift<Human> gift1 = humanBear.Open();
        //    gift1 = humanBear.Open();

        //    Gift<Elf> gift2 = elfBear.Open();
        //    gift2 = elfBear.Open();


        //    Console.ReadKey();
        //}




        interface IMagicBear
        {
            Type CreatureType
            {
                get;
                set;
            }
        }



        class MagicBear : IMagicBear
        {
            public Gift<T> Open<T>() where T : Creature
            {
                Console.Write("мішок({0}) ", this.GetHashCode());

                TimeSpan timeSpan = DateTime.Now - lastTry;
                if (timeSpan.TotalDays >= 1)
                {
                    lastTry = DateTime.Now;
                    CreatureType = typeof(T);
                    Console.WriteLine("В мішку дещо є! для {0}", typeof(T).Name);
                    return new Gift<T>();
                }
                else
                {
                    Console.WriteLine("Зараз в мішку нічого немає, зачекайте до {0:g}, залишилось {1} годин", lastTry.AddDays(1), (lastTry.AddDays(1) - DateTime.Now).TotalHours);
                    return null;
                }


            }

            Type creatureType;
            public Type CreatureType
            {
                get { return creatureType; }
                set { creatureType = value; }
            }

            DateTime lastTry;

            public MagicBear()
            {
                lastTry = DateTime.MinValue;
            }

        }


        class Gift<T>
        { }


        abstract class Creature
        {
        }
        class Human : Creature
        { }
        class Elf : Creature
        { }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            MagicBear bear = new MagicBear();


            bear.Open<Elf>();
            bear.Open<Elf>();
            bear.Open<Human>();

            Console.WriteLine(new string('-', 30));

            MagicBear bear2 = new MagicBear();
            bear2.Open<Human>();
            bear2.Open<Elf>();
            bear2.Open<Human>();

            Console.WriteLine(new string('-', 30));




            //MagicBear bear3 = new MagicBear();
            //bear3.Open<object>();
            //bear3.Open<Creature>();


            Console.ReadKey();
        }






    }
}
