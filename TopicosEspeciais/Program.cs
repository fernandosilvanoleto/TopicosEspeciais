using System;
using System.IO;
using System.Collections.Generic;
using TopicosEspeciais.Entities;
using TopicosEspeciais.Services;
using System.Globalization;
using TopicosEspeciais.Model.Entities_Her_Inter;
using TopicosEspeciais.Model.Entities_Her_Multipla;
using TopicosEspeciais.Model.Enums;

namespace TopicosEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                 * ATIVIDADE 01
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

                /*
                 * ATIVIDADE 02
                 * EXERCÍCIOS PROPOSTOS              


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
                 */


                /*
                 * ATIVIDADE 03
                 * COMPARANDO HERANÇA COM INTERFACE
                
                IShape s1 = new Circle() { Radius = 2.0, ColorAbstractShape = Color.White };

                IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, ColorAbstractShape = Color.Black };

                Console.WriteLine(s1);
                Console.WriteLine(s2);
                 */

                /*
                * ATIVIDADE 04
                * PROBLEMA DA PIRAMIDE - HERANÇA MÚLTIPLA
                */

                Pinter p = new Pinter() { SerialNumber = 1080 };
                p.ProcessDoc("My Letter");
                p.Pinters("My Letter");

                Scanner s = new Scanner() { SerialNumber = 2003 };
                s.ProcessDoc("My Email");
                Console.WriteLine(s.Scan());

                ComboDevice c = new ComboDevice { SerialNumber = 3291 };

                c.ProcessDoc("My Dissertation ProcessDoc");
                c.Pinters("My Dissertation Pinters");
                Console.WriteLine(c.Scan());

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
