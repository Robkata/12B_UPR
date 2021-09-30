using System;
using System.Collections.Generic;
using System.Linq;

namespace ListInputOutputLine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int index = 0; index < nums.Count; index++)
            {
                Console.WriteLine("nums[{0}] = {1}", index, nums[index]);
            }
        }
    }
}
