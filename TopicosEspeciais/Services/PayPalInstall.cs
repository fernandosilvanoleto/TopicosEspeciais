using System;
using System.Collections.Generic;
using System.Text;
using TopicosEspeciais.Entities;
using TopicosEspeciais.Entities;

namespace TopicosEspeciais.Services
{
    class PayPalInstall : IServicePagament
    {
        List<Installment> installments = new List<Installment>();
        public List<Installment> CalculateInstall(DateTime dateContract, double valueContract, int parcelas)
        {
            double aux;
            DateTime dataAux = dateContract;

            for (int i = 1; i <= parcelas; i++)
            {
                aux = valueContract/parcelas;
                aux = (((aux * 0.01) * i) + aux);
                aux = (aux + (aux * 0.02));
                dateContract = dataAux.AddMonths(i);
                installments.Add(new Installment (dateContract, aux));
            }
            return installments;
        }
    }
}
