using System;
using System.Collections.Generic;
using System.Text;
using TopicosEspeciais.Services;

namespace TopicosEspeciais.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime DateContract { get; set; }
        public double ValueContract { get; set; }
        public List<Installment> Installment { get; set; }

        private IServicePagament _servicePagament;

        public Contract() { }

        public Contract(int number, DateTime dateContract, double valueContract, IServicePagament servicePagament)
        {
            this.Number = number;
            this.DateContract = dateContract;
            this.ValueContract = valueContract;
            this.Installment = null;
            this._servicePagament = servicePagament;
        }

        public void CalculationsParcelas(int parcelas)
        {
            if (parcelas > 0)
            {
                Installment = _servicePagament.CalculateInstall(DateContract, ValueContract, parcelas);
            }            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Number: ");
            sb.AppendLine(Number.ToString());
            sb.Append("Date Contract: ");
            sb.AppendLine(Number.ToString("dd/MM/yyyy"));
            sb.Append("Value Contract: ");
            sb.AppendLine(ValueContract.ToString());
            sb.AppendLine();
            sb.AppendLine("Installments: ");
            foreach (Installment item in Installment)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
