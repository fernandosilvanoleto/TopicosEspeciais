using System;
using System.Collections.Generic;
using System.Text;

namespace TopicosEspeciais.Model.Entities_Her_Multipla
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        // CLASSE DO IPRINTER
        public void Pinters(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }

        // CLASSE DO DEVICE
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing " + document);
        }

        // CLASSE DO ISCANNER
        public string Scan()
        {
            return "ComboDevice Scan Result!!!";
        }
    }
}
