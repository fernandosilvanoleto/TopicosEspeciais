using System;
using System.Collections.Generic;
using System.Text;

namespace TopicosEspeciais.Model.Entities_Her_Multipla
{
    class Pinter : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Pinter Processing: " + document);
        }

        public void Pinters(string document)
        {
            Console.WriteLine("Pinter print " + document);
        }
    }
}
