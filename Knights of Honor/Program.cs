using System;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<string> Sir = w => Console.WriteLine("Sir " + w);

            foreach (var word in input)
            {
                Sir(word);
            }
        }
    }
}
