using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_09.Pupil.DerivedClasses
{
    internal class GoodPupil : Pupil
    {
        public override void Study() => Console.WriteLine("Good study");
        public override void Read() => Console.WriteLine("Good read");
        public override void Write() => Console.WriteLine("Good write");
        public override void Relax() => Console.WriteLine("Good relax");
    }
}
