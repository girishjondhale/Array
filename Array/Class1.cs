using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //int[] a = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //for (int i = 1; i <= a.Length; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("OnexTel");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Onex");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Tel");
            //    }
            //    else 
            //    {
            //        Console.WriteLine(i);
            //    }
            //question 1.WAP to replace all negative value with its immediate left elements square.Means arr[] = [12, 3, -19, 29, 5, -61, 44, 7, -9] Output array will be[12, 3, 9, 29, 5, 25, 44, 7, 49].
            int[] arr = new int[] { 12, 3, -19, 29, 5, -61, 44, 7, -9 };

            for (int i = 0; i <= arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    int j = i - 1;
                    arr[i] = arr[j] * arr[j];
                }
                Console.WriteLine(arr[i]);
            }


        }
    }
}
