using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());           

            for (int num = start; num <= end; num++)
            {
                int evenSum = 0;
                int oddSum = 0;
                int count = 0;
                int currNum = num;

                while (currNum != 0)
                {
                    int digit = currNum % 10;
                    if (count % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }               
                    count++;
                    currNum /= 10;                   
                }
                if (oddSum == evenSum)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
