using System;
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

            if (growthY == 0)
                return 0;

            if (targetZ <= 0 || growthY <= 0)
                return 0;

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
    }
}
