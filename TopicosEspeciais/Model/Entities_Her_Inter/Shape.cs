using System;
using System.Collections.Generic;
using System.Text;
using TopicosEspeciais.Model.Enums;

namespace TopicosEspeciais.Model.Entities_Her_Inter
{
    abstract class Shape
    {
        public Color ColorShape { get; set; }

        public abstract double Area();
    }
}
