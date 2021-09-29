using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            IEnumerable<string> reversedList = words.Reverse();

            foreach (string name in reversedList)
            {
                Console.WriteLine(String.Join(", ", name));
            }
        }
    }
}
