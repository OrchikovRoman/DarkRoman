using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyLibrary
{
    public static class FamilyKeeper
    {
        public static List<Family> Persons = new List<Family>();

        public static void Add(Family person)
        {
            Persons.Add(person);
        }
        public static void PrintListFamily()
        {
            Console.WriteLine("\nTotal number of items in the collection: {0}\n", Persons.Count);
            foreach (var person in Persons)
            {
                Console.WriteLine(person);
            }
        }
        public static void Delete(int target)
        {
            for (int i = 0; i < Persons.Count; ++i)
            {
                if (i+1 == target)
                {
                    Persons.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public class Family
    {
        public Family(string surname, string name, int age, string job, double salary, string purposeOfSavings, double amountForADream, double avarageMonthlyExpenses )
        {
            Surname = surname;
            Name = name;
            Age = age;
            Job = job;
            Salary = salary;
            PurposeOfSavings = purposeOfSavings;
            AmountForADream = amountForADream;
            AverageMonthlyExpenses = avarageMonthlyExpenses;
        }

        public string Surname { get; }
        public string Name { get; }
        public int Age { get; }
        public string Job { get; }                          
        public double Salary { get; set; }                  //зарплата
        public string PurposeOfSavings { get; }    
        public double AmountForADream { get; }              //Сумма цели накоплений
        public double AverageMonthlyExpenses { get; }       //Расходы в месяц
        public int target;

        public double  NumberOfSalariesForDream()
        {
            return AmountForADream / (Salary - AverageMonthlyExpenses);
        }

        public override string ToString()
        {
            return $"\nPerson {Surname} {Name} {Age} years working as an {Job} with a salary of {Salary} UAH, really wants to buy a {PurposeOfSavings}, which costs {AmountForADream} UAH. With his avarage monthly expenses, person can afford it with {NumberOfSalariesForDream():F1} salaries";
        }


    }
}
