using System;
using System.Collections.Generic;
using System.Text;
using TopicosEspeciais.Entities;

namespace TopicosEspeciais.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            this.PricePerHour = pricePerHour;
            this.PricePerDay = PricePerDay;
            this._taxService = taxService;
            // INJEÇÃO DE DEPENDÊNCIA POR MEIO DE CONSTRUTOR - INFORMAMOS POR MEIO DO CONSTRUTOR
        }

        public void ProcessInvoice(CarRental carRental)
        {
            // pegando duração de horas em C#
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
                //Math.Ceiling -> arrendonda para cima
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
