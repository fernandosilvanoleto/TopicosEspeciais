using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TopicosEspeciais.LAMBDA.Entities
{
    class ProductLAMBDA
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductLAMBDA(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
