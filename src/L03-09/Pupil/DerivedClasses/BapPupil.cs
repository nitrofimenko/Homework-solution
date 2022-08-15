using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_09.Pupil.DerivedClasses
{
    internal class BadPupil : Pupil
    {
        public override void Study() => Console.WriteLine("Bad study");
        public override void Read() => Console.WriteLine("Bad read");
        public override void Write() => Console.WriteLine("Bad write");
        public override void Relax() => Console.WriteLine("Bad relax");
    }
}
