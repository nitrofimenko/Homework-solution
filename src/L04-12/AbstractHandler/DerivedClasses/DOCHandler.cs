using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_12.AbstractHandler.DerivedClasses
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOCHandler Open() method");
        }
        public override void Create()
        {
            Console.WriteLine("DOCHandler Create() method");
        }
        public override void Change()
        {
            Console.WriteLine("DOCHandler Change() method");
        }
        public override void Save()
        {
            Console.WriteLine("DOCHandler Save() method");
        }
    }
}
