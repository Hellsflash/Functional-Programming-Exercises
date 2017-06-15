using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<long> predcate = n => n % 2 == 0;
            var range = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            var command = Console.ReadLine();
            if (command=="odd")
            {
                predcate = n => n % 2 != 0;
            }
            var output =new List<long>();
            for (long i = range[0]; i <= range[1]; i++)
            {
                if (predcate(i))
                {
                 output.Add(i);  
                }
            }
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
