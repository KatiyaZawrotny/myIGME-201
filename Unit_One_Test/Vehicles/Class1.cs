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

    // Class declaration for a Pickup that uses Car and IHeavyLoadCarrier and IPassengerCarrier
    public class Pickup : Car, IHeavyLoadCarrier, IPassengerCarrier
    {

    }

    // Class declaration for a Passenger Train that uses Train and IPassengerCarrier
    public class PassengerTrain : Train , IHeavyLoadCarrier, IPassengerCarrier
    {

    }

    // Class declaration for a Freight Train that uses Train and IHeavyLoadCarrier
    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }

    // Class declaration for a 424 Double Bogey (???? lol) (I had to add a letter in front so the class
    // name would be valid. C for Class) that uses Train and IHeavyLoadCarrier
    public class C424DoubleBogey : Train, IHeavyLoadCarrier
    {

    }
}
