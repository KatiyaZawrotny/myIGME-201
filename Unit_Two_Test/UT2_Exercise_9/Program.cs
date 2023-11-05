using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2_Exercise_9
{
    internal class Program
    {
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
