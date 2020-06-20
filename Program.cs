using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = Math.Max(Math.Max(a, b),(c));
            Console.WriteLine("max is");
            Console.WriteLine(max);
            Console.ReadKey();

        }
    }
}
