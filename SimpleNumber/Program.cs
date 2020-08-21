using System;

namespace SimpleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int simpleNumber = int.Parse(Console.ReadLine());
            
            for (int i = 2; i <= simpleNumber / 2; i++)
            {
                if (simpleNumber % i == 0)
                {
                    break;
                }


                Console.WriteLine(i + " простое число");
            }
                
                
        }
    }
}
