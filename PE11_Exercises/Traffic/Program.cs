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
        //Adds a passenger to an IPassengerCarrier by calling the inherited LoadPassenger method from IPassengerCarrier interface.
        public static void AddPassenger(IPassengerCarrier passengerCarrier)
        {
            passengerCarrier.LoadPassenger();
            Console.WriteLine("Passenger loaded!");
        }

        //Returns a string version of whhatever the method is enacted upon
        public override string ToString()
        {
            return base.ToString();
        }

        //Main creates testing variables and then calls their ToString() and adds a passenger if appropriate
        static void Main(string[] args)
        {
            //Initialize two vehicles for testing
            Pickup pickup = new Pickup();
            FreightTrain freightTrain = new FreightTrain();

            //Testing toString
            Console.WriteLine(pickup.ToString());
            //Add passenger successfully
            AddPassenger(pickup);

            Console.WriteLine(freightTrain.ToString());
            //AddPassenger(freightTrain);

            //Adding a non-IPassengerCarrier class causes the program to crash.

        }
    }
}
