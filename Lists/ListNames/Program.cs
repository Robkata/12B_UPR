using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            Console.WriteLine(string.Join("; ", names));
        }
    }
}
