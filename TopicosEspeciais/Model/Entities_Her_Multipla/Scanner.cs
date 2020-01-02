using System;
using System.Collections.Generic;
using System.Text;

namespace TopicosEspeciais.Model.Entities_Her_Multipla
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner Processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
