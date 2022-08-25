using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_12.AbstractHandler.DerivedClasses
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXTHandler Open() method");
        }
        public override void Create()
        {
            Console.WriteLine("TXTHandler Create() method");
        }
        public override void Change()
        {
            Console.WriteLine("TXTHandler Change() method");
        }
        public override void Save()
        {
            Console.WriteLine("TXTHandler Save() method");
        }
    }
}
