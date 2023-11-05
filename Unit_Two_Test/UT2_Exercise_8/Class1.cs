using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2_Exercise_8
{
    public class Art
    {
        public abstract class ArtMedium
        {
            public string Color
            {
                get; 
                set;
            }

            //Replace replaces a used medium such as an old pencil with a new one.
            public abstract void Replace();
            public virtual void Use()
            {
                Console.WriteLine("Using the medium!");
            }
        }

        public interface IDraw
        {
            void Draw();
        }

        public interface IInspiration
        {
            void Browse();
            void Sketch();
            bool Critique();
        }

        //ColoredPencil is a Medium that has a color and the ability to be replaced or sharpened
        public class ColoredPencil : ArtMedium, IDraw
        {
            public ColoredPencil(string color)
            {
                this.Color = color;
            }

            public override void Replace()
            {
                Console.WriteLine($"Replacing {this.Color} pencil with a new one.");
            }
            public void Sharpen()
            {
                Console.WriteLine($"Sharpening {this.Color} pencil.");
            }

            public void Draw()
            {
                Console.WriteLine("Drawing a Colored Pencil picture!");
            }

        }

        //ApplePen is a Medium who takes a color, can be replaced, or can be charged
        public class ApplePen : ArtMedium, IDraw
        {
            public ApplePen(string color)
            {
                this.Color = color;
            }
            public override void Replace()
            {
                Console.WriteLine("Time to blow $125 on another apple pen....");
            }
            public void Charge()
            {
                Console.WriteLine("Charging the apple pen!");
            }

            public void Draw()
            {
                Console.WriteLine("Drawing a digital picture on an IPad!");
            }
        }

        public class Pinterest : IInspiration
        {
            public void Browse()
            {
                Console.WriteLine("Browsing Pinterest!");
            }

            public bool Critique()
            {
                bool isGoodInspo;
                Random rand = new Random();
                int random = rand.Next(0,2);

                if (random == 0)
                {
                    isGoodInspo = false;
                }
                else
                {
                    isGoodInspo = true;
                }

                return isGoodInspo;

            }

            public void Sketch()
            {
                Console.WriteLine("Sketching out some ideas...");
            }
        }

        //FindInspiration takes a source of inspiration and uses it to determine a color
        public static string FindInspiration(IInspiration inspo)
        {
            string[] colors = new string[7] {"Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Pink" };
            Random rand = new Random();
            inspo.Browse();
            inspo.Sketch();
            while (true)
            {
                if (inspo.Critique())
                {
                    Console.WriteLine("This is some good inspiration!");
                    break;
                }
                else
                {
                    Console.WriteLine("This inspiration isn't good...time to keep looking.");
                }
            }

            return colors[rand.Next(0, colors.Length-1)];
            
        }

    }
    

}
