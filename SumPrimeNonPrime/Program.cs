using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                double sixthDigit = i % 10;
                double fifthDigit = i % 100;
                double fourthDigit = i % 1000;
                double thirdDigit = i % 10000;
                double secondDigit = i % 100000;
                double firstDigit = i % 1000000;

                double evenSum = sixthDigit + fourthDigit + secondDigit;
                double oddSum = fifthDigit + thirdDigit + firstDigit;

                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
