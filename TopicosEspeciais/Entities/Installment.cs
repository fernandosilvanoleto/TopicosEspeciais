using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TopicosEspeciais.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment() { }

        public Installment(DateTime dueDate, double amount)
        {
            this.DueDate = dueDate;
            this.Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                   + " - "
                   + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
