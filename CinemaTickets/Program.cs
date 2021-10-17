using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            int freePlaces = int.Parse(Console.ReadLine());

            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            int totalStudentTickets = 0;
            int totalStandardTickets = 0;
            int totalKidTickets = 0;

            int ticketsBought = 0;

                      
            while (true)
            {
                studentTickets = 0;
                standardTickets = 0;
                kidTickets = 0;

                int totalTicketsForCurrentProjection = 0;

                for (int i = 0; i < freePlaces; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "student")
                    {
                        studentTickets++;
                        totalStudentTickets += 1;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                        totalStandardTickets += 1;
                    }
                    else
                    {
                        kidTickets++;
                        totalKidTickets += 1;
                    }

                    ticketsBought++;

                    totalTicketsForCurrentProjection = studentTickets + standardTickets + kidTickets;

                    if (totalTicketsForCurrentProjection == freePlaces)
                    {
                        break;
                    }

                }
                double percentageTotal = (double)totalTicketsForCurrentProjection / freePlaces * 100;
                Console.WriteLine($"{film} - {percentageTotal:f2}% full.");
                film = Console.ReadLine();
                if (film == "Finish")
                {
                    break;
                }
                freePlaces = int.Parse(Console.ReadLine());
            }
            double perecentageStudent = (double)totalStudentTickets / ticketsBought * 100;
            double perecentageStandard = (double)totalStandardTickets / ticketsBought * 100;
            double perecentageKid = (double)totalKidTickets / ticketsBought * 100;

            Console.WriteLine($"Total tickets: {ticketsBought}\n{perecentageStudent:f2}% student tickets.\n{perecentageStandard:f2}% standard tickets.\n{perecentageKid:f2}% kids tickets.");
        }
    }
}
