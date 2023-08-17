using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class pair
    {
        static void Main(string[] args)
        {
            //Find pair of elements in array whose number is given number.
            //e.g.Given array is { 4, 5, 7, 1, 2, 3, 0 } If number given is 7.    
            //Then pairs whose sum is equal to given
            //number are – (4, 3)(5, 2)(7, 0)

            //int[] arr = new int[] { 4, 5, 7, 1, 2, 3, 0 };
            //Console.WriteLine("enter number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 1; j < arr.Length; j++)
            //    {
            //        int sum = arr[i] + arr[j];
            //        if (sum == num)
            //        {
            //            Console.WriteLine($"addition of pair{arr[i]} + {arr[j]}");
            //        }
            //    }

            //}

            //e.g. if given array is { 2, 10, 0, 5, 3, 0, 4, 1 } then output array should be
            //a. { 0,0,2,10,5,3,4,1}

            //int[] arr = new int[] { 2, 10, 0, 5, 3, 0, 4, 1 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i+1; j < arr.Length-1; j++)
            //    {
            //        int a;
            //        if (arr[j] == 0)
            //        {
            //            a = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = a;
            //        }
            //    }



            //}
            int[] array = new int[] { 3, 8, 5, 1, 2, 9, 4, 10 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
