using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_12.AbstractHandler.DerivedClasses
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XMLHadler Open() method");
        }
        public override void Create()
        {
            Console.WriteLine("XMLHandler Create() method");
        }
        public override void Change()
        {
            Console.WriteLine("XMLHandler Change() method");
        }
        public override void Save()
        {
            Console.WriteLine("XMLHandler Save() method");
        }
    }
}
