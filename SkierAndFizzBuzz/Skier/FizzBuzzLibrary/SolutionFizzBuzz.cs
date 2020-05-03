using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public class SolutionFizzBuzz
    {
        public static void CheckFirstFinishPoint(ref int startPoint, ref int finishPoint)
        {
            if (startPoint >= finishPoint)
            {
                var number = finishPoint;

                finishPoint = startPoint;

                startPoint = number;
            }
        }
        public static void Solution(FizzBuzzModel fizzBuzz)
        {
            var startPoint = fizzBuzz.startPoint;
            var finishPoint = fizzBuzz.finishPoint;
            var fizz = fizzBuzz.fizz;
            var buzz = fizzBuzz.buzz;
            var firstResult = fizzBuzz.firstDescription;
            var secondResult = fizzBuzz.secondDescription;

            CheckFirstFinishPoint(ref startPoint, ref finishPoint);

            for (; startPoint <= finishPoint; startPoint++)
            {
                string definition = "";

                if (startPoint % fizz == 0
                    || startPoint % buzz == 0
                    || (startPoint % (fizz * buzz) == 0))
                {
                    if (startPoint % (fizz * buzz) == 0)
                        definition = firstResult + secondResult;

                    else if (startPoint % fizz == 0)
                        definition = firstResult;

                    else if (startPoint % buzz == 0)
                        definition = secondResult;

                    Console.WriteLine(definition);
                }
                else
                    Console.WriteLine(startPoint.ToString());
            }
        }
    }
}
