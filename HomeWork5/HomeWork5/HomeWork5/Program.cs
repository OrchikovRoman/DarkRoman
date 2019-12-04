using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;


namespace HomeWork5
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
            Console.WriteLine("====I WELCOME YOU IN THE APP OF A TWO-DIMENSIONAL ARRAY ====");
            Console.WriteLine("============================================================");
        }
        static void ConsoleMenu()
        {

            bool isMenu = true;
            while (isMenu)
            {
                Console.WriteLine("\n<Press 1>: View two-dimensional array\n");
                Console.WriteLine("<Press 2>: Create a new two-dimensional array\n");
                Console.WriteLine("<Press 3>: Output the upper / lower triangular matrix\n");
                Console.WriteLine("<Press 4>: To transpose a two-dimensional array\n");
                Console.WriteLine("<Press 5>: To remove a two-dimensional array\n");
                Console.WriteLine("<Press D>: For clear Console\n");
                Console.WriteLine("<Press 9> double click: <EXIT>\n\n");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(" = Good choice!\n");
                        Console.WriteLine("============================================================");
                        ArrayKeeper.PrintListArray();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine(" = Good choice!\n");
                        Console.WriteLine("============================================================");
                        Console.WriteLine("Enter number of elements your square array: ");
                        int n = InputCheck();
                        var arrayNewArr = new ArrayLibrary.ArrayTwoDimensional(n);
                        ArrayTwoDimensional.CreateANewArray(n);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine(" = Good choice!\n");
                        ArrayKeeper.PrintTriangularMatrix();
                        break;

                    case ConsoleKey.D4:
                        Console.WriteLine(" = Good choice!\n");
                        ArrayKeeper.TransposeMatrices();
                        break;

                    case ConsoleKey.D5:
                        Console.WriteLine(" = Selected! Now you are on the dark side! \n");
                        Console.WriteLine("============================================================");
                        Console.WriteLine("Enter the number of the selected array you are going to break down into molecules: ");
                        int target = int.Parse(Console.ReadLine());
                        ArrayKeeper.Delete(target);
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
