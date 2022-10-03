using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_24
{
    struct Train
    {
        private string Destination { get; }
        public int TrainNumber { get; }
        private DateTime DepartureTime { get; }
        public Train(string destination,int trainNumber,DateTime departureTime)
        {
            Destination = destination;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }
        public void Show()
        {
            Console.WriteLine($"Destination: {Destination}\tTrain number: {TrainNumber}\tDeparture time: {DepartureTime:H:mm}");
        }
    }
}
