using System;
using System.Linq;

namespace Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Action<string> print = w => Console.WriteLine(w);

            foreach (var word in input)
            {
                print(word);
            }
        }
    }
}
