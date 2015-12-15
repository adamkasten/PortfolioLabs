using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp._7update
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fortune = { "I see memes in your future", "I see happiness in your future", "I see death in your future", "I see love in your future", "I see good times in the future", "I see wealth in your future" };
            Random ranNumberGen = new Random();
            int randomNum;
            randomNum = ranNumberGen.Next(0, 3);
            //different number gens
            Random ranNumberGen2 = new Random();
            int randomNum2;
            randomNum2 = ranNumberGen.Next(3, 6);
            string random1 = Convert.ToString(fortune[randomNum]);
            string random2 = Convert.ToString(fortune[randomNum2]);
            phrase(random1, random2);




        }

        private static void phrase(string random1, string random2)
        {
            Console.WriteLine("{0}", random1);
            Console.WriteLine("{0}", random2);
        }
    }
    }