using System;
using System.IO;
using System.Collections.Generic;
using TopicosEspeciais.Entities;
using TopicosEspeciais.Services;
using System.Globalization;

namespace TopicosEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                Console.WriteLine("Enter Rental data:");
                Console.WriteLine("Car Model: ");
                string model = Console.ReadLine();

                Console.WriteLine("Pickup (dd/mm/YYYY hh:mm)");
                DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                Console.WriteLine("Return (dd/mm/YYYY hh:mm)");
                DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                Console.WriteLine("Enter price per hour: ");
                double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Enter price per day: ");
                double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                CarRental carRental = new CarRental(start, finish, new Vehicle(model));

                RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

                rentalService.ProcessInvoice(carRental);

                Console.WriteLine("INVOCE");
                Console.WriteLine(carRental.Invoice);
                */

                Console.WriteLine("Enter contract data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("dd/MM/yyyy: ");
                DateTime dateContact = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.Write("Contract Value: ");
                double valueContract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Contract contract = new Contract(number, dateContact, valueContract, new PayPalInstall());
                
                Console.WriteLine("Enter number of installments: ");

                int parcelas = int.Parse(Console.ReadLine());
                contract.CalculationsParcelas(parcelas);

                Console.WriteLine(contract);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
