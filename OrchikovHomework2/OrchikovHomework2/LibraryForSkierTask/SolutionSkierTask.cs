using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryForSkierTask
{
    public static class SkierTaskKeeper
    {
        public static List<string> SkiersList = new List<string>();

        public static void Add(string skiers)
        {
            SkiersList.Add(skiers);
        }
        public static void PrintSkiersList()
        {
            Console.WriteLine("\nTotal number of items in the collection: {0}\n", SkiersList.Count);
            foreach (var skiers in SkiersList)
            {
                Console.WriteLine("================================");
                Console.WriteLine(skiers);
            }
        }
        public static void Delete(int target)
        {
            for (int i = 0; i < SkiersList.Count; ++i)
            {
                if (i + 1 == target)
                {
                    SkiersList.RemoveAt(i);
                    break;
                }
            }
        }
    }
    public class SkierTask
    {
        public double distX;  //норматив пробежки
        public double growthY;  //Процент прироста %
        public double targetZ;  //Цель километров

        public SkierTask(double distX, double growthY, double targetZ)
        {
            this.distX = distX;
            this.growthY = growthY;
            this.targetZ = targetZ;
        }
        public static void SolutionSkierTask(double distX, double growthY, double targetZ)
        {
            double sumOfPrevious = 0; //сумарная дистанция км предидущих дней
            double sumOfDays = 1; //сумма дней
            string distStart = distX.ToString();
            do
            {
                sumOfPrevious = sumOfDays + distX;
                distX = distX * (1 + (growthY / 100));
                sumOfDays = sumOfDays + 2;
            }
            while (sumOfPrevious < targetZ);
            string output = $"The skier began training on the first day with {distStart} km increased by {growthY}% of the previous day’s mileage. He will run {targetZ} km after {sumOfDays} days.";
            SkierTaskKeeper.Add(output);
        }
    }
}
