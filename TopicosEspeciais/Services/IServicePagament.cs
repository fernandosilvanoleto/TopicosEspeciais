using System;
using System.Collections.Generic;
using System.Text;
using TopicosEspeciais.Entities;

namespace TopicosEspeciais.Services
{
    interface IServicePagament
    {
        List<Installment> CalculateInstall(DateTime dateContract, double valueContract, int parcelas);
    }
}
