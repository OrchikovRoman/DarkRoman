using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryForSkierTask
{

    public class SolutionSkierTask
    {
        private double distX;  //норматив пробежки
        private double growthY;  //Процент прироста %
        private double targetZ;  //Цель километров
        public double sumOfPrevios; //сумарная дистанция км предидущих дней
        public double sumOfDays;  //сумма дней

        public SolutionSkierTask(double distX, double growthY, double targetZ)
        {
            this.distX = distX;
            this.growthY = growthY;
            this.targetZ = targetZ;
        }
        public static double Solution(double distX, double growthY, double targetZ, double sumOfPrevious, double sumOfDays)
        {
            sumOfPrevious = 0;
            sumOfDays = 1;
           
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
