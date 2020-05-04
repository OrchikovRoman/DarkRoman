using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkierLibrary
{
    public class SolutionSkier : IDisposable
    {
        public void Dispose()
        {
            //we are disposing it
        }

        public double Solution(double distX, double growthY, double targetZ)
        {
            if (Validator(distX, growthY, targetZ))
            {
                double sumOfPrevious = 0;
                double sumOfDays = 1;

                do
                {
                    sumOfPrevious = sumOfDays + distX;
                    distX = distX * (1 + (growthY / 100));
                    sumOfDays = sumOfDays + 2;
                }
                while (sumOfPrevious < targetZ);
                return sumOfDays;
            }
            return 0;
        }

        public bool Validator(double distX, double growthY, double targetZ)
        {
            if (growthY < 0)
            {
                Console.WriteLine("Growth Y cannot be negative");
                return false;
            }
            if (distX <= 0 || targetZ <= 0)
            {
                Console.WriteLine("Enter the number > 0");
                return false;
            }
            if (distX > targetZ)
            {
                Console.WriteLine("Please enter the distance X > target distance");
                return false;
            }
            return true;
        }
    }
}
