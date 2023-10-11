using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Collection of classes for the operation of vehicles
namespace Vehicles
{
    //Parent abstract vehicle class with methods declared
    public abstract class Vehicle
    {
        public void LoadPassenger() { }
    }

    //Interface for a general Passenger Carrier. Includes LoadPassenger method
    public interface IPassengerCarrier
    {
        //declaration for method that will load a passenger
        void LoadPassenger();
    }

    //Interface for a general Heavy Load Carrier
    public interface IHeavyLoadCarrier
    {

    }

    //abstract class for the definition of a car
    public abstract class Car : Vehicle
    {

    }
    //abstract class for the definition of a Train
    public abstract class Train : Vehicle
    {

    }

    // Class declaration for a compact that uses Car and IPassengerCarrier
    public class Compact : Car , IPassengerCarrier
    {
        
    }

    // Class declaration for an SUV that uses Car and IPassengerCarrier
    public class SUV : Car, IPassengerCarrier
    {

    }

    // Class declaration for a compact that uses Car and IHeavyLoadCarrier
    public class Pickup : Car, IHeavyLoadCarrier
    {

    }

}
