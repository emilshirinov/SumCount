using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            Console.Write(a % 10);
            while ((a /= 10) != 0)
            {
                Console.Write(a % 10);
            }
        }
    }
}
