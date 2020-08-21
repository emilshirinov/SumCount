using System;

namespace NumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int numberSum = 0;
            while (a > 0)
            {
                numberSum += a % 10;
                a /= 10;
            }
            Console.WriteLine(numberSum);
        }
    }
}
