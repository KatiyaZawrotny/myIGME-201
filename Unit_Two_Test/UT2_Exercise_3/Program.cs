using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2_Exercise_3
{
    internal class Program
    {
        //Main creates an indexable sorted list and loops to fill out the index tuples and z values
        static void Main()
        {
            // Initialize sortedlist to represent the indexable list of z values

            SortedList<(double, double, double), double> indexList = new SortedList<(double, double, double), double>();

            // Variables to store starting + ending + increment data for the x, y, and w values
            double xStart = 0.0;
            double xEnd = 4.0;
            double xIncrement = 0.1;

            double yStart = -1.0;
            double yEnd = 1.0;
            double yIncrement = 0.1;

            double wStart = -2.0;
            double wEnd = 0.0;
            double wIncrement = 0.2;

            //First loop for W's
            for (double w = wStart; w <= wEnd; w += wIncrement)
            {
                //Second loop for Y's
                for (double y = yStart; y <= yEnd; y += yIncrement)
                {
                    //third loop for X's
                    for (double x = xStart; x <= xEnd; x += xIncrement)
                    {
                        // With this loop's x, y, and w values, use the formula to get a z
                        double z = 4 * Math.Pow(y, 3) + 2 * Math.Pow(x, 2) - 8 * w + 7;

                        // Round the values to specified length
                        
                        x = Math.Round(x, 1);
                        y = Math.Round(y, 1);
                        w = Math.Round(w, 1);

                        z = Math.Round(z, 3);

                        // Create the tuple index with w, x, and y
                        (double, double, double) index = (w, x, y);

                        //Store z at the index
                        indexList[index] = z;
                    }
                }
            }

        }
    }
}


