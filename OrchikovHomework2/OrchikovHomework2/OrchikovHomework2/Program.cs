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
            ConsoleStart();
            ConsoleMenu();
        }
        static void ConsoleStart()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("========I WELCOME YOU IN THE APP OF A FIZZBUZZ==============");
            Console.WriteLine("============================================================");
        }
        static void ConsoleMenu()
        {

            bool isMenu = true;
            while (isMenu)
            {
                Console.WriteLine("\n<Press 1>: View list FizzBuzz\n");
                Console.WriteLine("<Press 2>: Create a new FizzBuzz\n");
                Console.WriteLine("<Press 3>: To remove a FizzBuzz\n");
                Console.WriteLine("<Press D>: For clear Console\n");
                Console.WriteLine("<Press 9> double click: <EXIT>\n\n");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(" = Good choice!\n");
                        Console.WriteLine("============================================================");
                        FizzBuzzKeeper.PrintListFizzBuzz();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine(" = Good choice!\n");
                        Console.WriteLine("============================================================");
                        Console.WriteLine("Please enter the beginning of a number border: ");
                        int startPoint = InputCheck();
                        Console.WriteLine("Please enter the end of the number border: ");
                        int finishPoint = InputCheck();
                        Console.WriteLine("Enter the Fizz prime number: ");
                        int fizz = InputCheck(); 
                        Console.WriteLine("Enter the Buzz prime number: "); 
                        int buzz = InputCheck();
                        var result = new FizzBuzz(startPoint, finishPoint, fizz, buzz);
                        FizzBuzz.FizzBuzzSolution(startPoint, finishPoint, fizz, buzz);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine(" = Selected! Now you are on the dark side! \n");
                        Console.WriteLine("============================================================");
                        Console.WriteLine("Enter the number of the selected solution you are going to break down into molecules: ");
                        int target = int.Parse(Console.ReadLine());
                        FizzBuzzKeeper.Delete(target);
                        break;

                    case ConsoleKey.D:
                        Console.Clear();
                        break;

                    case ConsoleKey.D9:
                        Environment.Exit(0);
                        break;
                }
                
            }

        }
        static int InputCheck()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect number, try again");
            }
            return number;
        }
        //static int PrimeInputCheck()
        //{
            
        //    int number;
        //    if (number > 0)
        //    {
        //        for (int i = 2; i < number; i++)
        //            while ((number % i == 0 && number != i && i != 1))
        //            {
        //                Console.WriteLine("Please input prime number!");
        //                number = int.Parse(Console.ReadLine());
        //            }
        //    }
        //    if (number < 0)
        //    {
        //        for (int i = number; i < -2; i++)
        //            while ((number % i == 0 && number != i && i != 1))
        //            {
        //                Console.WriteLine("Please input prime number!");
        //                number = int.Parse(Console.ReadLine());
        //            }
        //    }
        //    return number;
        //}


    }
}
