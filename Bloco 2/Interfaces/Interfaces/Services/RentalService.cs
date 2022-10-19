using System;
using Interfaces.Entities;

namespace Interfaces.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrasilTaxService _brasilTaxService = new BrasilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoid(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPaypent = 0.0;

            if(duration.TotalHours <= 12.0)
            {
                basicPaypent = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPaypent = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double Tax = _brasilTaxService.Tax(basicPaypent);

            carRental.Invoice = new Invoice(basicPaypent, Tax);
        }

    }
}
