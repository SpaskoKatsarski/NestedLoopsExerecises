using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int current = 1;
            bool isEqual = false;

            for (int rows = 1; rows <= num; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > num)
                    {
                        isEqual = true;
                        break;
                    }
                    Console.Write($"{current} ");
                    current++;
                }
                if (isEqual)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
