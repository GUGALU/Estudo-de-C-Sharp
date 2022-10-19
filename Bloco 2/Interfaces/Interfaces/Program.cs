using System;
using Interfaces.Entities;
using Interfaces.Services;
using System.Globalization;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup date dd/MM/yyyy: ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return date dd/MM/yyyy: ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour,day, new BrasilTaxService());

            rentalService.ProcessInvoid(carRental);

            Console.WriteLine("Invoice: ");
            Console.Write(carRental.Invoice);
        }
    }
}
