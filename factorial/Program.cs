using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            double  fact = 1;
            Console.WriteLine("Введите число");
            double currentValue = double .Parse(Console.ReadLine());

            for (double i = currentValue; i > 1; i--)
            {
                fact = i * fact;
            }
            Console.WriteLine("Факториал числа = " + fact);
                
        }
    }
}
