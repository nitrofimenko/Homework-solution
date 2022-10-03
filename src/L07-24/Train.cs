using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_24
{
    struct Train
    {
        private string destination;
        private string trainNumber;
        private DateTime departureTime;
        public string TrainNumber { get { return trainNumber; } }
        public Train(string destination,string trainNumber,DateTime departureTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }
        public void Show()
        {
            Console.WriteLine($"Destination: {destination}\nTrain number: {trainNumber}\nDeparture time: {departureTime:H:mm}");
        }
    }
}
