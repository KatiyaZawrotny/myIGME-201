using System;

namespace Mandelbrot
{
    class Class1
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mandelbrot Set Generator!");

            double imagCoordStart, imagCoordEnd;
            double realCoordStart, realCoordEnd;

            // Prompt the user for imagCoord range
            Console.Write("Enter the starting value for imagCoord (e.g., 1.2): ");
            while (!double.TryParse(Console.ReadLine(), out imagCoordStart) || imagCoordStart <= -1.2)
            {
                Console.WriteLine("Invalid input. Please enter a valid starting value (greater than -1.2).");
            }

            Console.Write("Enter the ending value for imagCoord (e.g., -1.2): ");
            while (!double.TryParse(Console.ReadLine(), out imagCoordEnd) || imagCoordEnd >= 1.2 || imagCoordEnd >= imagCoordStart)
            {
                Console.WriteLine("Invalid input. Please enter a valid ending value (less than 1.2 and lower than the starting value).");
            }

            // Prompt the user for realCoord range
            Console.Write("Enter the starting value for realCoord (e.g., -0.6): ");
            while (!double.TryParse(Console.ReadLine(), out realCoordStart) || realCoordStart >= 1.77)
            {
                Console.WriteLine("Invalid input. Please enter a valid starting value (less than 1.77).");
            }

            Console.Write("Enter the ending value for realCoord (e.g., 1.77): ");
            while (!double.TryParse(Console.ReadLine(), out realCoordEnd) || realCoordEnd <= -0.6 || realCoordEnd <= realCoordStart)
            {
                Console.WriteLine("Invalid input. Please enter a valid ending value (greater than -0.6 and higher than the starting value).");
            }

            // Calculate the increments based on the desired number of values
            double imagCoordIncrement = (imagCoordEnd - imagCoordStart) / 48.0;
            double realCoordIncrement = (realCoordEnd - realCoordStart) / 80.0;

            int iterations;

            for (double imagCoord = imagCoordStart; imagCoord >= imagCoordEnd; imagCoord -= imagCoordIncrement)
            {
                for (double realCoord = realCoordStart; realCoord <= realCoordEnd; realCoord += realCoordIncrement)
                {
                    iterations = 0;
                    double realTemp = realCoord;
                    double imagTemp = imagCoord;
                    double arg = (realCoord * realCoord) + (imagCoord * imagCoord);

                    while ((arg < 4) && (iterations < 40))
                    {
                        double realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp) - realCoord;
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
