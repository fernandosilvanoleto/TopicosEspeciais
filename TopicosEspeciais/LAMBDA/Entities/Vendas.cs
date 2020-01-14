using System;
using System.Collections.Generic;
using System.Text;

namespace TopicosEspeciais.LAMBDA.Entities
{
    class Vendas
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Vendas(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
