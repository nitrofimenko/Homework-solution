using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace L07_24
{
    class TrainsList
    {
        private int trainsMaxNumber;
        private Train[] trains;
        private int trainsNumber = 0;
        public TrainsList(int trainsMaxNumber, bool immediatelyFullComplete = false)
        {
            this.trainsMaxNumber = trainsMaxNumber;
            trains = new Train[trainsMaxNumber];

            if (immediatelyFullComplete)
            {
                for (int i = 0; i < this.trainsMaxNumber; i++)
                {
                    AddTrain();
                }
                SortByTrainNumber();
            }
        }
        public void AddTrain()
        {
            if (trainsNumber >= trainsMaxNumber)
            {
                return;
            }
            trains[trainsNumber] = TrainFactory.CreateTrain(trainsNumber);
            trainsNumber++;
        }
        public void SortByTrainNumber()
        {
            IEnumerable<Train> query = trains.OrderBy(train => train.TrainNumber);
            trains = query.ToArray();
        }
        public void SearchAndShow(int trainNumber)
        {
            bool noMatches = true;
            for (int i = 0; i < trainsNumber; i++)
            {
                if (trains[i].TrainNumber == trainNumber)
                {
                    trains[i].Show();
                    noMatches = false;
                }
            }
            if (noMatches)
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
