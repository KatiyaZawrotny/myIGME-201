using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

//Program simulates traffic using the vehicle classes we created
namespace Traffic
{
    //Program simulates traffic using the vehicle classes we created
    internal class Program
    {
        public void AddPassenger(IPassengerCarrier passengerCarrier)
        {
            passengerCarrier.LoadPassenger();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        static void Main(string[] args)
        {
            Pickup pickup = new Pickup();
            FreightTrain freightTrain = new FreightTrain();


        }
    }
}
