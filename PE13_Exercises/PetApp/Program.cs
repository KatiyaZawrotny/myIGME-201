using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PetApp.Program;

namespace PetApp
{
    internal class Program
    {
        //Abstract class for the creation of a Pet
        public abstract class Pet
        {
            private string name;
            public int age;

            public string Name
            {
                get
                {
                    return name;
                }
            }

            public abstract void Eat();
            public abstract void Play();
            public abstract void GotoVet();

            public Pet(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        //interface for a Cat
        public interface ICat
        {
            void Eat();
            void Play();
            void Purr();
            void Scratch();

        }

        //interface for a Dog
        public interface IDog
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();


        }

        //Class for Pet called Dog that can Bark and NeedWalk
        public class Dog : Pet, IDog
        {
            public string license;

            public Dog(string szLicence, string szName, int nAge) : base(szName, nAge)
            {
            }

            public override void Eat()
            {
                throw new NotImplementedException();
            }

            public override void Play()
            {
                throw new NotImplementedException();
            }

            public override void GotoVet()
            {
                throw new NotImplementedException();
            }

            public void Bark()
            {
                throw new NotImplementedException();
            }

            public void NeedWalk()
            {
                throw new NotImplementedException();
            }
        }

        //Class for a Cat that can Scratch and Purr
        public class Cat : Pet, ICat
        {
            public Cat(string name, int age) : base(name, age)
            {
            }

            public override void Eat()
            {
                throw new NotImplementedException();
            }

            public override void GotoVet()
            {
                throw new NotImplementedException();
            }

            public override void Play()
            {
                throw new NotImplementedException();
            }

            public void Purr()
            {
                throw new NotImplementedException();
            }

            public void Scratch()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
