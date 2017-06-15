using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> func = MinElement;
            Console.WriteLine(func(input));

        }

        private static int MinElement(List<int> input)
        {
            return input.Min();
        }
    }
}
