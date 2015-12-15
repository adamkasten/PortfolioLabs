using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp._11update
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program named SubscriptExceptionTest in which you declare an array of 20 doubles and store values in the array. 
            //Write a try block in which you place a loop that prompts the user for a subscript value and displays the value stored in the corresponding array position. 
            //Create a catch block that catches any IndexOutOfRangeException and displays an appropriate error message.

            double[] newArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20.6 };
            int input;

            for (int i = 0; i < newArray.Length; i++)
            {
                try
                {
                    Console.WriteLine("Hey boss! Enter in a postion of a number in the array to display it.");
                    input = int.Parse(Console.ReadLine());
                    Console.WriteLine(newArray[input]);
                }
                catch (IndexOutOfRangeException e)
                {

                    Console.WriteLine("NONONONONONONO that isn't a position in the array.");
                }
            }

        }
    }
}
