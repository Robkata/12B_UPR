using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numbers = new List<int>();
            for (int index = 0; index < nums.Count; index++)
            {
                if(nums[index] % 2 == 0)
                {
                    numbers.Add(nums[index]);
                }
            }
            Console.WriteLine(string.Join($" ", numbers));
        }
    }
}
