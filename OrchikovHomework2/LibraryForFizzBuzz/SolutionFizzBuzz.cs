using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForFizzBuzz
{
    public class SolutionFizzBuzz
    {
        private int startPoint;
        private int finishPoint;
        private int fizz;
        private int buzz;
        public int arraySize;
        public string[] answerNum;

        public SolutionFizzBuzz(int startPoint, int finishPoint, int fizz, int buzz)
        {
            this.startPoint = startPoint;
            this.finishPoint = finishPoint;
            this.fizz = fizz;
            this.buzz = buzz;
        }

        public static string[] Solution(int startPoint, int finishPoint, int fizz, int buzz, int arraySize)
        {
            arraySize = (finishPoint - startPoint)+1;
            string[] answerNum = new string[arraySize];
            for (int i = startPoint; i < answerNum.Length; i++)
            {
                var output = "";
                if (i % fizz == 0 && i % buzz == 0) answerNum[i] = ("FizzBuzz");
                else if (i % fizz == 0) answerNum[i] = ("Fizz");
                else if (i % buzz == 0) answerNum[i] = ("Buzz");
                else output = (answerNum[i]).ToString(); //I did not quite manage to understand this before the deadline, please explain, I would be very grateful for this piece of knowledge.
            }
            return answerNum; 
        }
    }
}
