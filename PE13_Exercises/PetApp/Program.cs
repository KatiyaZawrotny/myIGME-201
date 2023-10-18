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
            public Pet()
            {

            }


            public Pet(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public abstract void Eat();
            public abstract void Play();
            public abstract void GotoVet();



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
                Console.WriteLine(Name + " eats their food!");
            }

            public override void Play()
            {
                Console.WriteLine(Name + " plays with a ball! Fetch!");
            }

            public override void GotoVet()
            {
                Console.WriteLine(Name + " has been taken to the vet!");
            }

            public void Bark()
            {
                Console.WriteLine(Name + " barks!");
            }

            public void NeedWalk()
            {
                Console.WriteLine(Name + " needs a walk!");
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
                Console.WriteLine(Name + " eats their food!");
            }

            public override void GotoVet()
            {
                Console.WriteLine(Name + " has been taken to the vet!");
            }

            public override void Play()
            {
                Console.WriteLine(Name + " plays with a laser pointer!");
            }

            public void Purr()
            {
                Console.WriteLine(Name + " purrs!");
            }

            public void Scratch()
            {
                Console.WriteLine(Name + " scratches you! Bad kitty!");
            }
        }

        //Class for containing and managing several pets
        public class Pets
        {
            List<Pet> petList = new List<Pet>();

            public Pet this[int nPetEl]
            {
                get
                {
                    Pet returnVal;
                    try
                    {
                        returnVal = (Pet)petList[nPetEl];
                    }
                    catch
                    {
                        returnVal = null;
                    }

                    return (returnVal);
                }

                set
                {
                    // if the index is less than the number of list elements
                    if (nPetEl < petList.Count)
                    {
                        // update the existing value at that index
                        petList[nPetEl] = value;
                    }
                    else
                    {
                        // add the value to the list
                        petList.Add(value);
                    }
                }
            }

            public int Count
            {
                get
                {
                    return petList.Count;
                }
            }

            public void Add(Pet pet)
            {
                petList.Add(pet);
            }

            public void Remove(Pet pet)
            {
                petList.Remove(pet);
            }

            public void RemoveAt(int petEl)
            {
                petList.RemoveAt(petEl);
            }


        }
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;
        }
    }
}
