using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    //CafeLib is a class library that has classes to let customers order various hot drinks from waiters
    public class CafeLib
    {
        // HotDrink is an abstract class which is a blueprint CupOfCoffee, CupOfTea, and CupOfCocoa
        public abstract class HotDrink
        {
            bool instant;
            bool milk;
            byte sugar;
            string size;
            Customer customer;
            public HotDrink() { }
            public HotDrink(string brand) { }

            public virtual void AddSugar(byte amount) { }

            public abstract void Steam();
            
        }

        //IMood is an interface that is used by Waiter and Customer to show their moods
        public interface IMood
        {
            string Mood
            {
                get;
            }
        }

        //ITakeOrder is an interface used by various HotDrinks to have their order recorded
        public interface ITakeOrder
        {
            void TakeOrder();
        }

        //Waiter is a class that uses IMood and has a name, representing a waiter
        public class Waiter : IMood
        {
            string name;

            public string Mood
            {
                get 
                {
                    throw new NotImplementedException();
                }
            }

            
        }

        //Customer is a class that uses IMood and has a name and credit card #, representing a customer
        public class Customer : IMood
        {
            string name;
            string creditCardNumber;
            public string Mood
            {
                get
                {
                    throw new NotImplementedException();
                }
            }


        }

        // CupOfCoffee is a class that uses HotDrink and implements the ITakeOrder interface to represent a cup of coffee
        public class CupOfCoffee : HotDrink, ITakeOrder
        {
            string beanType;

            public CupOfCoffee(string brand) : base(brand) { }

            public override void Steam()
            {
                throw new NotImplementedException();
            }

            public void TakeOrder()
            {
                throw new NotImplementedException();
            }
        }

        // CupOfTea is a class that uses HotDrink and implements the ITakeOrder interface to represent a cup of tea
        public class CupOfTea : HotDrink, ITakeOrder
        {
            string leafType;

            public CupOfTea(bool customerIsWealthy) { }

            public override void Steam()
            {
                throw new NotImplementedException();
            }

            public void TakeOrder()
            {
                throw new NotImplementedException();
            }
        }

        // CupOfCocoa is a class that uses HotDrink and implements the ITakeOrder interface to represent a cup of cocoa
        public class CupOfCocoa : HotDrink, ITakeOrder
        {
            static int numCups;
            bool marshmallows;
            string source;

            public CupOfCocoa() : this(false) { }

            public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand") { }

            public string Source
            {
                set 
                {
                    source = value;
                }
            }

            public override void Steam()
            {
                throw new NotImplementedException();
            }

            public override void AddSugar(byte amount)
            {
                throw new NotImplementedException();
            }

            public void TakeOrder()
            {
                throw new NotImplementedException();
            }
        }
    }
}
