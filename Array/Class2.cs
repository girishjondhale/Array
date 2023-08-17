using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Class2
    {

        class Program
        {
            static void Main(string[] args)
            {
                string[] inputArray = { "i", "am", "very", "smartsss" };
                string concatenatedString = ConcatenateStrings(inputArray);
                string[] outputArray = GenerateSubstringArray(concatenatedString, inputArray.Length);

                foreach (string s in outputArray)
                {
                    Console.WriteLine(s);
                }
            }

            static string ConcatenateStrings(string[] arr)
            {
                string result = "";
                foreach (string s in arr)
                {
                    result += s;
                }
                return result;
            }

            static string[] GenerateSubstringArray(string str, int length)
            {
                string[] result = new string[length];
                int substringLength = (int)Math.Ceiling((double)str.Length / length);
                int remainingChars = str.Length;

                for (int i = 0; i < length; i++)
                {
                    if (i == length - 1)
                    {
                        result[i] = str.Substring(i * substringLength).PadRight(substringLength, '#');
                    }
                    else
                    {
                        result[i] = str.Substring(i * substringLength, substringLength);
                        remainingChars -= substringLength;
                    }
                }

                return result;
            }
        }
    }
}
