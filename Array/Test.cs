using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Test
    {
        static void Main(string[] args)
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int rem, sum = 0;
            while (num > 0)
            {

                rem = num % 10;

                if (rem % 2 != 0)
                {
                    sum = sum + rem;
                }
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }

}
