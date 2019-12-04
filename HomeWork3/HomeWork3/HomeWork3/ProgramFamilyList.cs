using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyLibrary;


namespace HomeWork3
{
    class ProgramFamilyList
    {
        static void Main(string[] args)
        {
            ConsoleStart();
            var personEugene = new Family("Klushin", "Eugene", 27, "Interior designer", 23000, "Volkswagen Passat B5+", 170000, 7000);
            var personElisabeth = new Family("Klushina", "Elizabeth", 22, "Shop assistant", 10000, "Robot vacuum cleaner", 10000, 6000);
            FamilyKeeper.Add(personEugene);
            FamilyKeeper.Add(personElisabeth);

            ConsoleMenu();

            Console.ReadKey();
        }
        static void ConsoleStart()
        {
            Console.WriteLine("================================="); //Then I really did "brrrrrr", referring to your black magic
            Console.WriteLine("====WELCOME TO MY FAMILY APP!====");
            Console.WriteLine("================================="); 
        }
        static void ConsoleMenu()
        {

            bool isMenu = true;
            while (isMenu)
            {
                Console.WriteLine("\n<Press 1>: View family members\n");
                Console.WriteLine("<Press 2>: Create a new larva of society\n");
                Console.WriteLine("<Press 3>: Split into molecules an individual of the human race (O_o)\n");
                Console.WriteLine("<Press D>: For clear Console\n");
                Console.WriteLine("<Press 9> double click: <EXIT>\n\n");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(" = Good choice!\n");
                        Console.WriteLine("===============================================");
                        FamilyKeeper.PrintListFamily();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine(" = Selected\n");
                        Console.WriteLine("===============================================");
                        Console.WriteLine("Please enter the surname of your new person: ");
                        string surnameNewPers = Console.ReadLine();
                        Console.WriteLine("Please enter the name of your new person: ");
                        string nameNewPers = Console.ReadLine();
                        Console.WriteLine("Please enter the age of your new person: ");
                        int ageNewPers;
                        while (!Int32.TryParse(Console.ReadLine(), out ageNewPers))
                        {
                            Console.WriteLine("Input Error! Insert the number type Int32");
                        }
                        Console.WriteLine("Please tell me who your new person works: ");
                        string jobNewPers = Console.ReadLine();
                        Console.WriteLine("Please tell me how much your new person earns in UAH: ");
                        double salaryNewPers;
                        while (!double.TryParse(Console.ReadLine(), out salaryNewPers))
                        {
                            Console.WriteLine("Input Error! Insert the number type double");
                        }
                        Console.WriteLine("Please write the dream your new person wants to buy: ");
                        string purposeOfSavingsNewPers = Console.ReadLine();
                        Console.WriteLine("How much is the dream of your new man?(PS: UAH) ");
                        double amountForADreamNewPers;
                        while (!double.TryParse(Console.ReadLine(), out amountForADreamNewPers))
                        {
                            Console.WriteLine("Input Error! Insert the number type double");
                        }
                        Console.WriteLine("Well, the last thing, what are the average expenses per month for your new person, please indicate in numbers: (UAH)");
                        double avarageMonthlyExpensesNewPers;
                        while (!double.TryParse(Console.ReadLine(), out avarageMonthlyExpensesNewPers))
                        {
                            Console.WriteLine("Input Error! Insert the number type double");
                        }
                        var personNewPers = new Family(surnameNewPers, nameNewPers, ageNewPers, jobNewPers, salaryNewPers, purposeOfSavingsNewPers, amountForADreamNewPers, avarageMonthlyExpensesNewPers);
                        FamilyKeeper.Add(personNewPers);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine(" = Selected! Now you are on the dark side! \n");
                        Console.WriteLine("===============================================");
                        Console.WriteLine("Enter the number of the selected person you are going to break down into molecules: ");
                        int target = int.Parse(Console.ReadLine());
                        FamilyKeeper.Delete(target);
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

    }
                
}
