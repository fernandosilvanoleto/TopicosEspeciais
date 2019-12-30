using System;
using System.Collections.Generic;
using System.Text;

namespace TopicosEspeciais.Services
{
    class BrazilTaxService : ITaxService
    {
        // realização de uma interface
        public double Tax(double amount)
        {
            if(amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
