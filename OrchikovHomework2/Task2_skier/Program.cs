using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryForSkierTask.LibraryForSkierTask;

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
    }
}
