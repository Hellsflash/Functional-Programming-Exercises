using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int, int[]> reverseFunc = ReverseList;
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var number = int.Parse(Console.ReadLine());
            int[] output = reverseFunc(input, number);
            Console.WriteLine(string.Join(" ", output));
        }

        public static int[] ReverseList(int[] input, int number)
        {
            var result = new List<int>();
            Predicate<int> isNotDivisable = x => x % number != 0;

            for (int i = input.Length-1; i >= 0; i--)
            {
                if (isNotDivisable(input[i]))
                {
                    result.Add(input[i]);
                }
            }
            return result.ToArray();
        }
    }
}
