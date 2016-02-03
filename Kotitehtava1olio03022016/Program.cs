using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava1olio03022016
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();
            List<int> list4 = new List<int>();
            List<int> list5 = new List<int>();
            List<int> list6 = new List<int>();
            int times = 1;
            int a = 0;
            Console.Write("How many times shall we roll the dice? : ");
            times = int.Parse(Console.ReadLine());
            Console.WriteLine("Rolling " + times + " times...");
            // luodaan olio Dice-luokasta
            Dice dice = new Dice();
            while (a < times)
            {

                int number = dice.Throw();
            //  System.Threading.Thread.Sleep(50);
                list.Add(number);
                a++;
                if (number == 1)
                {
                    list1.Add(number);
                }
                else if (number == 2)
                {
                    list2.Add(number);
                }
                else if (number == 3)
                {
                    list3.Add(number);
                }
                else if (number == 4)
                {
                    list4.Add(number);
                }
                else if (number == 5)
                {
                    list5.Add(number);
                }
                else
                {
                    list6.Add(number);
                }
            }
            Console.WriteLine("Average : {0}", list.Average());

            Console.WriteLine("Total amount of rolls : {0}", list.Count);
            Console.WriteLine("1 rolled : {0}", list1.Count);
            Console.WriteLine("2 rolled : {0}", list2.Count);
            Console.WriteLine("3 rolled : {0}", list3.Count);
            Console.WriteLine("4 rolled : {0}", list4.Count);
            Console.WriteLine("5 rolled : {0}", list5.Count);
            Console.WriteLine("6 rolled : {0}", list6.Count);
            Console.ReadLine();
            Console.ReadLine();



        }
    }
}
