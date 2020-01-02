using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TopicosEspeciais.Model.Entities_Her_Inter
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle Color = "
                //+ ColorShape // USO DA CLASSE DE HERANÇA
                + ColorAbstractShape // USO DA CLASSE DE INTERFACE
                + ", width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", área = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
