using System;
using System.Linq;

namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> filter = n => n % 2 == 0;
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Array.Sort(input, (x1, x2) =>
            {
                if (!filter(x1) && filter(x2))
                {
                    return 1;
                }
                if (filter(x1) && !filter(x2))
                {
                    return -1;
                }
                return x1.CompareTo(x2);
            });
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
