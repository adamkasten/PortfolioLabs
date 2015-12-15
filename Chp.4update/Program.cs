using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp._4update
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number 1 through 10");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            Random ranNumberGen = new Random();
            int randomNum;
            randomNum = ranNumberGen.Next(1, 10);

            if (inputNum == randomNum)
                Console.WriteLine(randomNum + " Correct");
            else if (inputNum < randomNum)
                Console.WriteLine(randomNum + " Too Low");
            else if (inputNum > randomNum)
                Console.WriteLine(randomNum + " Too High");
        }
    }
}
