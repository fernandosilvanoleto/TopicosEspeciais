using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TopicosEspeciais.Model.Entities_Her_Inter
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle Color = "
                //+ ColorShape // USO DA CLASSE DE HERANÇA
                + ColorAbstractShape // USO DA CLASSE DE INTERFACE
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", área = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
