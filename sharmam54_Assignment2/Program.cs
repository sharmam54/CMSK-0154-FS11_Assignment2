
using System;

class Program
{
    static void Main(string[] args)
    {
        int sumEven = 0;
        int sumOdd = 0;

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"Number {i} is even");
                sumEven += i;
            }
            else
            {
                Console.WriteLine($"Number {i} is odd");
                sumOdd += i;
            }
        }

        Console.WriteLine($"Sum of even numbers: {sumEven}");
        Console.WriteLine($"Sum of odd numbers: {sumOdd}");

        Console.ReadKey();
      
    }
}
