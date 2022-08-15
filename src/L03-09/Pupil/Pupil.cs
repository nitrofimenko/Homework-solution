using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_09.Pupil
{
    internal class Pupil
    {
        public virtual void Study() => Console.WriteLine("Base study");
        public virtual void Read() => Console.WriteLine("Base read");
        public virtual void Write() => Console.WriteLine("Base write");
        public virtual void Relax() => Console.WriteLine("Base relax");
    }
}
