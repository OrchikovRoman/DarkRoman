using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForSkierTask;

namespace Task2_skier
{
    class Program
    {
        static void Main(string[] args)
        {
            double distX, growthY, targetZ;

            Console.WriteLine("Enter the distance of the first skier training: ");
            while (!double.TryParse(Console.ReadLine(), out distX)) 
            {
                Console.WriteLine("Input Error! Insert the number");
            }
            Console.WriteLine("Enter the percentage of increase in distance training skier: ");
            while (!double.TryParse(Console.ReadLine(), out growthY))
            {
                while (IsPositiveNumber(growthY).Equals(true))
                {
                    Console.WriteLine("pidr");
                }
                Console.WriteLine("Input Error! Insert the number");
            }
            Console.WriteLine("Enter the goal of the skier in kilometers: ");
            while (!double.TryParse(Console.ReadLine(), out targetZ))
            {
                Console.WriteLine("Input Error! Insert the number");
            }
            

            var result = new SolutionSkierTask();
            var answer =  result.Solution(distX, growthY, targetZ);
            
            Console.WriteLine("The skier will reach the goal {0} on the {1} day", targetZ, answer);
            Console.ReadKey();
        }

        public static bool IsPositiveNumber(double input)
        {
            bool result = true;
            if (input <= 0)
            {
                Console.WriteLine("Value cannot be negative. Please input number more than 0");

                return false;
            }
            return result;
        }
    }
}
