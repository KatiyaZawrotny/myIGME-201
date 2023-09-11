using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            double imagCoordStart, imagCoordEnd, realCoordStart, realCoordEnd;

            Console.Write("Enter your desired starting coordinate value (ex: 1.2): ");
            while (!double.TryParse(Console.ReadLine(), out imagCoordStart) || imagCoordStart <= -1.2)
            {
                Console.WriteLine("Invalid input");
            }

            Console.Write("Enter your desired ending coordinate value (ex: -1.2): ");
            while (!double.TryParse(Console.ReadLine(), out imagCoordEnd) || imagCoordEnd >= 1.2 || imagCoordEnd >= imagCoordStart)
            {
                Console.WriteLine("Invalid input");
            }

            Console.Write("Enter your desired starting real coord value (ex: -0.6): ");
            while (!double.TryParse(Console.ReadLine(), out realCoordStart) || realCoordStart >= 1.77)
            {
                Console.WriteLine("Invalid input");
            }

            Console.Write("Enter your desired ending real coord value (ex: 1.77): ");
            while (!double.TryParse(Console.ReadLine(), out realCoordEnd) || realCoordEnd <= -0.6 || realCoordEnd <= realCoordStart)
            {
                Console.WriteLine("Invalid input");
            }

            for (imagCoord = imagCoordStart; imagCoord >= imagCoordEnd; imagCoord -= 0.05)
            {
                for (realCoord = realCoordStart; realCoord <= realCoordEnd; realCoord += 0.03)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
