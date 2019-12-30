using System;
using System.Collections.Generic;
using System.Text;

namespace TopicosEspeciais.Services
{
    interface ITaxService
    {
        // O "I" em C# diz que a classe é uma interface

        double Tax(double amount);

    }
}
