using System;

namespace HotelAppWeek6
{
    internal class Program
    {
        // divider helper
        static void PrintDivider()
        {
            Console.WriteLine(new string('-', 70));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tWelcome to Hotel App (Week 6) - Updated");
            int i = 0;
            string[] name = new string[20];
            int[] night = new int[20];
            string[] roomservice = new string[20];
            double[] costlist = new double[20];

            while (true)
            {
                Console.WriteLine("Enter Customer Name:");
                string Name = Console.ReadLine();
                name[i] = Name;

                Console.WriteLine("Enter Number of nights:");
                int NumberOfnight = int.Parse(Console.ReadLine());
                night[i] = NumberOfnight;

                Console.WriteLine("Enter yes/no to indicate whether you want room service:");
                string roomService = Console.ReadLine();
                roomservice[i] = roomService;

                double cost = 0;
                if (NumberOfnight <= 3) cost = NumberOfnight * 100;
                else if (NumberOfnight <= 10) cost = NumberOfnight * 80.5;
                else cost = NumberOfnight * 75.3;

                if (roomService.ToLower() == "yes")
                    cost += cost * 0.10;

                costlist[i] = cost;
                Console.WriteLine($"Total price for {Name} is ${cost}");

                i++;

                Console.WriteLine("________________________________________");
                Console.WriteLine("Press q to exit or any other key to continue:");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "q") break;
                Console.WriteLine("________________________________________");
            }

            // summary
            PrintDivider();
            Console.WriteLine("\t\tSummary of Reservation");
            PrintDivider();
            Console.WriteLine("Name\t\tNights\t\tRoom Service\t\tCharge");
            for (int j = 0; j < i; j++)
                Console.WriteLine($"{name[j]}\t\t{night[j]}\t\t{roomservice[j]}\t\t${costlist[j]}");

            // closing message (Change 2)
            PrintDivider();
            Console.WriteLine("Thank you for using Hotel App Week 6!");
        }
    }
}
