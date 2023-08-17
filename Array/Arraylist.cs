using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Arraylist
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30 };
            int[] arr2 = new int[8];
            ArrayList list = new ArrayList();

            list.Add(15);
            list.Add(20);
            list.Add(55);

            list.Insert(0, 1);
            list.Insert(2, 200);

            list.AddRange(arr);

            list.Remove("Hello");
            list.RemoveAt(0);
            list.RemoveRange(1, 3);

            list.Sort();
            list.Reverse();

            list.CopyTo(arr2);

            bool res = list.Contains(250);
            Console.WriteLine(res);

            Console.WriteLine("No of elements present in the collection " + list.Count);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
