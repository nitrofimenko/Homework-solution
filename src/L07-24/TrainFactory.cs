using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_24
{
    static internal class TrainFactory
    {
        public static Train CreateTrain(int recordNumber)
        {
            Console.WriteLine($"Train {recordNumber}");
            Console.Write("Destination: ");
            string destination = Console.ReadLine();
            Console.Write("Train number: ");
            int trainNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Departure time: ");
            DateTime departureTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(new String('-', 20));
            return new Train(destination, trainNumber, departureTime);
        }
    }
}
