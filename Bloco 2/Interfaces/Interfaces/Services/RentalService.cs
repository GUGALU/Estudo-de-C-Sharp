using System;
using Interfaces.Entities;

namespace Interfaces.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _TaxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
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

            double Tax = _TaxService.Tax(basicPaypent);

            carRental.Invoice = new Invoice(basicPaypent, Tax);
        }

    }
}
