using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForFizzBuzz
{
    public static class FizzBuzzKeeper
    {
        public static List<string> FizzBuzzList = new List<string>();

        public static void Add(string answerFizzBuzz)
        {
            FizzBuzzList.Add(answerFizzBuzz);
        }
        public static void PrintListFizzBuzz()
        {
            Console.WriteLine("\nTotal number of items in the collection: {0}\n", FizzBuzzList.Count);
            foreach(var answerFizzBuzz in FizzBuzzList)
            {
                Console.WriteLine("================================");
                Console.WriteLine(answerFizzBuzz);
            }
        }
        public static void Delete(int target)
        {
            for (int i = 0; i < FizzBuzzList.Count; ++i)
            {
                if (i + 1 == target)
                {
                    FizzBuzzList.RemoveAt(i);
                    break;
                }
            }
        }
    }
    public class FizzBuzz
    {
        public int startPoint;
        public int finishPoint;
        public int fizz;
        public int buzz;

        public FizzBuzz(int startPoint, int finishPoint, int fizz, int buzz)
        {
            this.startPoint = startPoint;
            this.finishPoint = finishPoint;
            this.fizz = fizz;
            this.buzz = buzz;
        }

        public static void FizzBuzzSolution(int startPoint, int finishPoint, int fizz, int buzz)
        {
            
            var output = "";
            if (startPoint < finishPoint)
            {
                for (int i = startPoint; i <= finishPoint; i++)
                {
                    if (i % fizz == 0 && i % buzz == 0) output += "FizzBuzz\n";
                    else if (i % fizz == 0) output += "Fizz\n";
                    else if (i % buzz == 0) output += "Buzz\n";
                    else output += i.ToString() + "\n";
                }
            }
            else if (startPoint>finishPoint)
            {
                for (int i = finishPoint; i <= startPoint; i++)
                {
                    if (i % fizz == 0 && i % buzz == 0) output += "FizzBuzz\n";
                    else if (i % fizz == 0) output += "Fizz\n";
                    else if (i % buzz == 0) output += "Buzz\n";
                    else output += i.ToString() + "\n";
                }
            }
            
            FizzBuzzKeeper.Add(output);   
        }
    }
}
