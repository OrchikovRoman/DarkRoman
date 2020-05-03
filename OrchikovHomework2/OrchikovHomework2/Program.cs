using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForFizzBuzz;

namespace OrchikovHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoint, finishPoint, fizz, buzz;
            
            Console.WriteLine("Please enter the beginning of a number border: ");
            while (!int.TryParse(Console.ReadLine(), out startPoint))
            {
                Console.WriteLine("Input Error! Insert the number");
            }
            
            Console.WriteLine("Please enter the end of the number border: ");
            while (!int.TryParse(Console.ReadLine(), out finishPoint))
            {
                Console.WriteLine("Input Error! Insert the number");
            }
            
            Console.WriteLine("Enter the Fizz prime number: ");
            while (!int.TryParse(Console.ReadLine(), out fizz))
            {
                Console.WriteLine("Input Error! Insert the number");
            }

            Console.WriteLine("Enter the Buzz prime number: ");
            while (!int.TryParse(Console.ReadLine(), out buzz))
            {
                Console.WriteLine("Input Error! Insert the number");
            }

            Console.WriteLine("Enter the description for \"fizz\"");

            string firstDescription = Console.ReadLine();
            Console.WriteLine("Enter the description for \"buzz\"");
            string secondDescription = Console.ReadLine();



            var model = new FizzBuzzModel()
            {
                startPoint = startPoint,
                finishPoint = finishPoint,
                fizz = fizz,
                buzz = buzz,
                firstDescription = firstDescription,
                secondDescription=secondDescription,
            };

            SolutionFizzBuzz.Solution(model);

            Console.ReadKey();
        }

    }
}
