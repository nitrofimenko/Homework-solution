using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_24
{
    static internal class TrainFactory
    {
        private static string destination;
        private static int trainNumber;
        private static DateTime departureTime;
        public static Train CreateTrain(int trainNumber)
        {
            Console.WriteLine($"Train {trainNumber}");
            Console.Write("Destination: ");
            destination = Console.ReadLine();
            Console.Write("Train number: ");
            trainNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Departure time: ");
            departureTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(new String('-', 20));
            int position;
            return new Train(destination, trainNumber, departureTime);
        }
    }
}
