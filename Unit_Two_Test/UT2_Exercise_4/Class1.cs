using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UT2_Exercise_4.PhoneLibrary;

namespace UT2_Exercise_4
{
    //PhoneLibrary contains classes to create different types of phones
    public class PhoneLibrary
    {
        //Phone is an abstract class with base stubs for its fields, a property for the phone number, and methods for connecting and disconnecting
        public abstract class Phone
        {
            private string phoneNumber;
            public string address;

            public string PhoneNumber
            {
                get
                {
                    return phoneNumber;
                }
                set
                {
                    phoneNumber = value;
                }
            }

            public abstract void Connect();
            public abstract void Disconnect();


        }

        //PhoneInterface is an interface to be used by different types of phones to provide basic methods to answer, make, and hang up calls.
        public interface PhoneInterface
        {
            void Answer();
            void MakeCall();
            void HangUp();

        }

        //RotaryPhone is a child of Phone that implements PhoneInterface
        public class RotaryPhone : Phone, PhoneInterface
        {
            public void Answer()
            {
                throw new NotImplementedException();
            }

            public void HangUp()
            {
                throw new NotImplementedException();
            }

            public void MakeCall()
            {
                throw new NotImplementedException();
            }

            public override void Connect()
            {
                throw new NotImplementedException();
            }

            public override void Disconnect()
            {
                throw new NotImplementedException();
            }
        }

        //PushButtonPhone is a child of Phone that implements PhoneInterface
        public class PushButtonPhone : Phone, PhoneInterface
        {
            public void Answer()
            {
                throw new NotImplementedException();
            }

            public void HangUp()
            {
                throw new NotImplementedException();
            }

            public void MakeCall()
            {
                throw new NotImplementedException();
            }

            public override void Connect()
            {
                throw new NotImplementedException();
            }

            public override void Disconnect()
            {
                throw new NotImplementedException();
            }
        }

        //Tardis is a child of RotaryPhone with a bunch of Dr. Who references I don't understand!! 
        public class Tardis : RotaryPhone
        {
            private bool sonicScrewdriver;
            private byte whichDrWho;
            private string femaleSideKick;
            public double exteriorSurfaceArea;
            public double interiorVolume;

            public byte WhichDrWho
            {
                get
                {
                    return whichDrWho;
                }
            }

            public string FemaleSideKick
            {
                get
                {
                    return femaleSideKick;
                }
            }

            public void TimeTravel()
            {
                throw new NotImplementedException();
            }

            public static bool operator ==(Tardis tardis1, Tardis tardis2)
            {
                if (tardis1 is null && tardis2 is null)
                    return true;
                if (tardis1 is null || tardis2 is null)
                    return false;

                if (tardis1.WhichDrWho == 10 && tardis2.WhichDrWho != 10)
                    return true;
                else if (tardis1.WhichDrWho != 10 && tardis2.WhichDrWho == 10)
                    return false;

                return tardis1.WhichDrWho < tardis2.WhichDrWho;
            }

            public static bool operator !=(Tardis tardis1, Tardis tardis2)
            {
                return !(tardis1 == tardis2);
            }

            public static bool operator <(Tardis tardis1, Tardis tardis2)
            {
                return tardis1.WhichDrWho < tardis2.WhichDrWho;
            }

            public static bool operator >(Tardis tardis1, Tardis tardis2)
            {
                return tardis1.WhichDrWho > tardis2.WhichDrWho;
            }

            public static bool operator <=(Tardis tardis1, Tardis tardis2)
            {
                return tardis1.WhichDrWho <= tardis2.WhichDrWho;
            }
            public static bool operator >=(Tardis tardis1, Tardis tardis2)
            {
                return tardis1.WhichDrWho >= tardis2.WhichDrWho;
            }
        }

        //PhoneBooth is a child of PushButtonPhone 
        public class PhoneBooth : PushButtonPhone
        {
            private bool superMan;
            public double costPerCall;
            public bool phoneBook;

            public void OpenDoor()
            {
                throw new NotImplementedException();
            }

            public void CloseDoor()
            {
                throw new NotImplementedException();
            }
        }

        static void UsePhone(PhoneInterface phone)
        {
            phone.MakeCall();
            phone.HangUp();

            if (phone is Tardis tardis)
            {
                Console.WriteLine("Tardis Identified.");
                tardis.TimeTravel();
            }
            else if (phone is PhoneBooth phoneBooth)
            {
                Console.WriteLine("Phone Booth Identified.");
                phoneBooth.OpenDoor();
            }
        }

        static void Main(string[] args)
        {
            Tardis tardis = new PhoneLibrary.Tardis();
            PhoneBooth phoneBooth = new PhoneLibrary.PhoneBooth();

            UsePhone(tardis);
            UsePhone(phoneBooth);
        }

    }
}
