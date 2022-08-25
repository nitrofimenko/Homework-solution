using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_14.Document.Parts
{
    internal abstract class Part
    {
        public abstract string Content { protected get; set; }
        public abstract void Show();
    }
}
