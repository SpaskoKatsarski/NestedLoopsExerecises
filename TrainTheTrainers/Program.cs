using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            double sumAllMarks = 0;
            int counter = 0;

            while (presentation != "Finish")
            {
                double sumCurrent = 0;
                double averageCurrent = 0;

                for (int i = 0; i < judges; i++)
                {
                    double currentMark = double.Parse(Console.ReadLine());
                    sumAllMarks += currentMark;
                    sumCurrent += currentMark;
                    counter++;
                }
                averageCurrent += sumCurrent / judges;
                Console.WriteLine($"{presentation} - {averageCurrent:f2}.");
                presentation = Console.ReadLine();
            }
            double average = sumAllMarks / counter;
            Console.WriteLine($"Student's final assessment is {average:f2}.");
        }
    }
}
