using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Task");
            Console.WriteLine("Enter a 2-digit number N");
            int N = int.Parse(Console.ReadLine());

            if (N < 10 || N > 99)
            {
                Console.WriteLine("Error, the number must be two digits");
                return;
            }

            int suma = 0;
            Console.WriteLine($"Even numbers between 1 and {N}");
            for (int i = 1; i <= N; i++)
            {
                if (i% 2 == 0)
                { 
                 Console.WriteLine(i);
                 suma += i; 

                }

            }
            Console.WriteLine($"The add of the even numbers is: {suma}");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Second Task");
            double X = Math.PI / 8;
            double epsilon = Math.Pow(-4, 10);
            //other values
            double SumS1 = 0;
            double Actualterm;
            int n = 1;

            do
            {
                Actualterm = (Math.Pow(n, -1)) * (1 / Math.Pow(n, 2) + n * X);
                SumS1 += Actualterm;

                Console.WriteLine($"Iteration:{n}");
                Console.WriteLine($"Actual term: {Actualterm}");
                Console.WriteLine($"The value of the cumulative sum of the S1 series: {SumS1}");
                Console.WriteLine($"The error reached in the current iteration: {Math.Abs(Actualterm / SumS1)}");
                n++;

            } while (Actualterm > epsilon);
            Console.WriteLine();
            Console.WriteLine("Calculated Complete");
            Console.WriteLine($"The final Sum of the S1 series: {SumS1}");
            Console.WriteLine($"The number of iterations: {n}");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.WriteLine() ;


            Console.WriteLine("Third Task");
            Console.WriteLine();
            double a = 0.5;
            double b = 11;
            double h = 0.3;
            Console.WriteLine("x = a");
            Console.WriteLine("Function y = sin(x)/x^2");
            Console.WriteLine("Function z = cos(x)/x");
            Console.WriteLine();

            for (double x = a; x <= b; x += h)
            {
                double y = Math.Sin(x) / Math.Pow(x, 2);
                double z = Math.Cos(x) / x;

                Console.WriteLine($"x:{x}, y:{y}, z:{z}");
                
            }


            Console.ReadKey();

        }
    }
}
