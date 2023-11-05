using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UT2_Exercise_8.Art;

namespace UT2_Exercise_9
{
    internal class Program
    {
        //FindInspiration takes a source of inspiration and uses it to determine a color
        public static string FindInspiration(object obj)
        {
            string[] colors = new string[7] { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Pink" };
            Random rand = new Random();

            if (obj is UT2_Exercise_8.Art.IInspiration inspo)
            {
               
                
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

                
            }
            return colors[rand.Next(0, colors.Length - 1)];

        }

        //Main searches for inspirtion and then uses the color to create a colored pencil and apple pen. Then, uses the respective mediums.
        static void Main(string[] args)
        {
            UT2_Exercise_8.Art.Pinterest pinterest = new UT2_Exercise_8.Art.Pinterest();
            string color = UT2_Exercise_8.Art.FindInspiration(pinterest);

            UT2_Exercise_8.Art.ColoredPencil coloredPencil = new UT2_Exercise_8.Art.ColoredPencil(color);
            UT2_Exercise_8.Art.ApplePen applePen = new UT2_Exercise_8.Art.ApplePen(color);

            coloredPencil.Use();
            coloredPencil.Sharpen();
            coloredPencil.Replace();

            applePen.Charge();
            applePen.Use();
            applePen.Replace();

        }
    }
}
