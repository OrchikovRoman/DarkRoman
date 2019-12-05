using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0)
                Console.WriteLine("Число кратное 3");
            else
                Console.WriteLine("Число не кратное 3");
            if (a % 7 == 0)
                Console.WriteLine("Число кратное 7");
            else
                Console.WriteLine("Число не кратное 7");
            Console.ReadKey();
        }
    }
}
