using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_11
{
    internal class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document opened.");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Document editing available in Pro version.");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving a document available in Pro version.");
        }
    }
}
