using System;

namespace SumCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNumberSum = 0;
            int evenNumberCount = 0;
            
            

            for (int start = 1; start <= 99; start++)
            {
                if (start % 2 == 0)
                {
                    evenNumberCount++;
                    evenNumberSum += start;
                }
            }

            Console.WriteLine("Сумма чисел " + evenNumberSum);
            Console.WriteLine("Количество чисел " + evenNumberCount);
            
        }
    }
}
