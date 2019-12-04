using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuadraticEquationLibrary;

namespace HomeWork1v2
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
            Console.WriteLine("====I WELCOME YOU IN THE APP OF A QUADRATIC EQUATION========");
            Console.WriteLine("============================================================");
        }
        static void ConsoleMenu()
        {

            bool isMenu = true;
            while (isMenu)
            {
                Console.WriteLine("\n<Press 1>: View quadratic equations\n");
                Console.WriteLine("<Press 2>: Create a new quadratic equation\n");
                Console.WriteLine("<Press 3>: To remove a qudratic equation\n");
                Console.WriteLine("<Press D>: For clear Console\n");
                Console.WriteLine("<Press 9> double click: <EXIT>\n\n");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(" = Good choice!\n");
                        Console.WriteLine("============================================================");
                        QuadraticEquationKeeper.PrintQuadraticEquation();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine(" = Good choice!\n");
                        Console.WriteLine("============================================================");
                        Console.WriteLine("Enter parameter a: ");
                        double a = InputCheck();
                        Console.WriteLine("Enter parameter b: ");
                        double b = InputCheck();
                        Console.WriteLine("Enter parameter c: ");
                        double c = InputCheck();
                        var quadraticEquationNew = new QuadraticEquation(a,b,c);
                        QuadraticEquation.SolutionQuadraticEquation(a, b, c);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine(" = Selected! Now you are on the dark side! \n");
                        Console.WriteLine("============================================================");
                        Console.WriteLine("Enter the number of the selected array you are going to break down into molecules: ");
                        int target = int.Parse(Console.ReadLine());
                        QuadraticEquationKeeper.Delete(target);
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
    }
}
