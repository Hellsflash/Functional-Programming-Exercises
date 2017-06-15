using System;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> subtract = Subtract;
            Action<int[]> add = Add;
            Action<int[]> multiply = Multiply;
            Action<int[]> print = Print;

            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        add(input);
                        break;
                    case "subtract":
                        subtract(input);
                        break;
                    case "multiply":
                        multiply(input);
                        break;
                    case "print":
                        print(input);
                        break;
                }
                command = Console.ReadLine();
            }
        }

        public static void Print(int[] input)
        {
            Console.WriteLine(string.Join(" ", input));
        }

        public static void Subtract(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i]--;
            }
        }

        public static void Add(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i]++;
            }
        }

        public static void Multiply(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] *= 2;
            }
        }
    }
}
