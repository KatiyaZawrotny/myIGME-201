using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //min and max for x
            int xMin = -1;
            int xMax = 1;

            //min and max for y
            int yMin = 1;
            int yMax = 4;

            //increment
            double increment = 0.1;

            //find dimensions of array
            int xIterations = (int)((xMax - xMin)/increment);
            int yIterations = (int)((yMax - yMin)/increment);

            Console.Write(xIterations + "  " + yIterations);


            double[,,] valueArray = new double[xIterations,yIterations,3];

            for (int i1 = 0; i1 <xIterations; i1++)
            {
                //convert index to the correct value of x
                double x = xMin + i1 * increment;
                for (int i2 = 0; i2 < yIterations; i2++)
                {
                    //convert index 2 to the correct value of y
                    double y = yMin + i2 * increment;
                    // calculate z
                    double z = 3 * Math.Pow(y, 2) + (2 * x) - 1;
                    
                    //store values in value array
                    valueArray[i1,i2, 0] = x;
                    valueArray[i1, i2, 1] = y;
                    valueArray[i1, i2, 2] = z;
                }
            }
            
        }
    }
}
