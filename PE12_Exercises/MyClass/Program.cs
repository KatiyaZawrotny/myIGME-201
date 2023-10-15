using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Program
    {
        //MyClass contains a write-only field for a string and a virtual method GetString that returns the string
        public class MyClass
        {
            private string myString;

            //constructor, takes a string
            public MyClass(string stringValue)
            {
                myString = stringValue;
            }

            //Property to make myString write-only
            public string MyString
            {
                set
                {
                    myString = value;
                }
            }

            //getter method for myString
            public virtual string GetString()
            {
                return myString;
            }
        }
        //MyDerivedClass is a subclass of MyClass that overrides the GetString() method 
        public class MyDerivedClass : MyClass
        {
            //constructor
            public MyDerivedClass(string stringValue) : base(stringValue) { }
         
            //Overridden getter adds in an extra string at the end
            public override string GetString()
            {
                return base.GetString() + " (output from the derived class)";
            }
        }

        //Main tests the creation and implementation of MyDerivedClass
        static void Main(string[] args)
        {
            MyDerivedClass dClass = new MyDerivedClass("Test");
            Console.WriteLine(dClass.GetString());
        }
    }
}
