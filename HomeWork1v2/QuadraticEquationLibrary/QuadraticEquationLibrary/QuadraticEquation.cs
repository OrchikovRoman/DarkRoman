using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationLibrary
{
    public class QuadraticEquationKeeper
    {
        public static List<string> Equations = new List<string>();

        public static void Add(string equation)
        {
            Equations.Add(equation);
        }
        public static void PrintQuadraticEquation()
        {
            Console.WriteLine("\nTotal number of items in the collection: {0}\n", Equations.Count);
            foreach (var equation in Equations)
            {
                Console.WriteLine("================================");
                Console.WriteLine(equation);
            }
        }
        public static void Delete(int target)
        {
            for (int i = 0; i < Equations.Count; ++i)
            {
                if (i + 1 == target)
                {
                    Equations.RemoveAt(i);
                    break;
                }
            }
        }
    }
    public class QuadraticEquation : IDisposable
    {
        public double DiscriminantCalculation(double a, double b, double c)
        {
            CheckZeroNumbers(a);
            CheckZeroNumbers(b);
            CheckZeroNumbers(c);
            double D = Math.Pow(b, 2) - 4 * a * c;
            return D;
        }

        public void RootCalculation(ref double a, ref double b, ref double c, out double x1, out double x2)
        {
            CheckZeroNumbers(a);
            CheckZeroNumbers(b);
            CheckZeroNumbers(c);
            x1 = x1 = 0;
            x2 = x2 = 0;
            string quadEquation = "";
            var D = DiscriminantCalculation(a, b, c);
            if (D > 0)
            {
                x1 = (-b - (Math.Sqrt(D))) / (2 * a);
                x2 = (-b + (Math.Sqrt(D))) / (2 * a);
                quadEquation = $"Roots of the equation: x1={x1:F1}, x2={x2:F1} \nLinear factorization: {a}x^2+{b}x+{c}={a}(x-{x1:F1})(x-{x2:F1})\n";
            }
            else if (D == 0)
            {
                x1 = (-b + (Math.Sqrt(D))) / (2 * a);
                quadEquation = $"Roots of the equation: x1={x1} \nLinear factorization: {a}x^2+{b}x+{c}={a}(x-{x1:F1})\n";
            }
            else quadEquation = $"{a}x^2+{b}x+{c}=0 - The quadratic equation has no roots!\n";
            QuadraticEquationKeeper.Add(quadEquation.Replace("--", "+"));
        }

        public double CheckZeroNumbers(double num)
        {
            if (num == 0)
                throw new Exception("Your number cannot be zero.");
            return num;
        }
        public void Dispose()
        {
            //we are disposing it
        }
    }
}
