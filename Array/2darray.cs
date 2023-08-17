using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class _2darray
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            int[,] arr2 = new int[3, 3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"enter values for arr[{i}, {j}]");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());

                }



            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.WriteLine($"enter values for arr2[{i}, {j}]");
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());

                }


            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + arr2[i, j] + " ");
                }
                Console.WriteLine();


            }

        }
    }
}
