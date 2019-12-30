using System;
using System.Collections.Generic;
using System.Text;

namespace TopicosEspeciais.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime DateContract { get; set; }
        public double ValueContract { get; set; }

        public Contract() { }

        public Contract(int number, DateTime dateContract, double valueContract)
        {
            this.Number = number;
            this.DateContract = dateContract;
            this.ValueContract = valueContract;
        }

        public void CalculationsParcelas(int parcelas)
        {
            Console.WriteLine("Parcelas para pagar: " + parcelas);
        }

        public override string ToString()
        {
            return "Oi";
        }
    }
}
