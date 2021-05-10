using System;
using System.IO;
using Estudo_try.Entities;

namespace Estudo_try
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be later than Check-in.");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();

                Console.WriteLine("Enter data to update reservation:");
                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation ddates must be future dates");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: Check-out date muste be later than check-in");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }

            
        }
    }
}
