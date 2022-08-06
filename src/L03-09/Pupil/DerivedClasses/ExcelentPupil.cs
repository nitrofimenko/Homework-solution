using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_09.Pupil.DerivedClasses
{
    internal class ExcelentPupil : Pupil
    {
        public override void Study() => Console.WriteLine("Excellent study");
        public override void Read() => Console.WriteLine("Excellent read");
        public override void Write() => Console.WriteLine("Excellent write");
        public override void Relax() => Console.WriteLine("Excellent relax");
    }
}
