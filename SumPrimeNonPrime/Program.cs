using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int sumOfAllPrimeNums = 0;
            int sumOfAllNonPrimeNums = 0;

            while (command != "stop")
            {
                int number = int.Parse(command);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int counter = 0;

                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            counter++;
                        }                    
                    }
                    if (counter == 2)
                    {
                        sumOfAllPrimeNums += number;
                    }
                    else
                    {
                        sumOfAllNonPrimeNums += number;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfAllPrimeNums}\nSum of all non prime numbers is: {sumOfAllNonPrimeNums}");
        }
    }
}