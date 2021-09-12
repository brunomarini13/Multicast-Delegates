using System;

namespace StudyProject.Services
{
    static class CalculationService
    {
        public static void Sum(double x, double y)
        {
            double result = x + y;
            Console.WriteLine("Sum result: " + result);
        }

        public static void Subtract(double x, double y)
        {
            double result = x - y;
            Console.WriteLine("Subtract result: " + result);
        }

        public static void Multiply(double x, double y)
        {
            double result = x * y;
            Console.WriteLine("Multiply result: " + result);
        }
    }
}
