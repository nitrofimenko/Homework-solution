using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_13
{
    internal class Player : IPlayable, IRecodable
    {
        public void Play() => Console.WriteLine("Play");
        void IPlayable.Pause() => Console.WriteLine("Pause (Play)");
        void IPlayable.Stop() => Console.WriteLine("Stop (Play)");
        public void Record() => Console.WriteLine("Record");
        void IRecodable.Pause() => Console.WriteLine("Pause (Record)");
        void IRecodable.Stop() => Console.WriteLine("Stop (Record)");
    }
}
