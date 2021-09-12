using System;
using System.Linq;
using StudyProject.Services;

namespace StudyProject
{
    delegate void NumericalOperations(double x, double y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input x: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Input y: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            NumericalOperations op = CalculationService.Sum;
            op += CalculationService.Subtract;
            op += CalculationService.Multiply;

            op(n1, n2);
        }
    }
}
