using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            IEnumerable<int> reversedList = array.Reverse();

            foreach (int arr in reversedList)
            {
                Console.WriteLine(String.Join(", ", arr));
            }
        }
    }
}
