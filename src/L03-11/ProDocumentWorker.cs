using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_11
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited.");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document swved in old format, saving in another formats available in Expert version.");
        }
    }
}
