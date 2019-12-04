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

            LibraryForFizzBuzz.SolutionFizzBuzz result = new SolutionFizzBuzz(startPoint, finishPoint, fizz, buzz);
            string[] answer = SolutionFizzBuzz.Solution(startPoint,finishPoint,fizz,buzz,result.arraySize);

            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine("{0}\n", answer[i]);
            }
            Console.ReadKey();
        } 
        
    }
}
