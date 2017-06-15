using System;

namespace Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();
            Predicate<string> filter = x => x.Length <= number;
            foreach (var name in names)
            {
                if (filter(name))
                {
                    Console.WriteLine(name);
                }
                
            }
        }
    }
}
