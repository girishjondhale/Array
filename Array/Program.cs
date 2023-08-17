using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //syntax
            // set of integers
            string[] names = new string[10] { "sachin", "ravi", "pratik", "aa", "nilesh", "ganesh", "ram", "girish", "sanket", "suresh" };
            string[] bike = new string[5] { "rtr", "rc", "r15", "mt", "1" };

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            // sort

            Array.Sort(names);
            Console.WriteLine("------after sort------");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(names);
            Console.WriteLine("------after reverse------");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Array.Copy(names, 4, bike, 4, 1);
            Console.WriteLine("------------------");
            foreach (var item in bike)
            {
                Console.WriteLine(item);
            }
        }

    }
}
