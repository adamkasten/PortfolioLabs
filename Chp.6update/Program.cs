using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp._6update
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] eight = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("Enter in a command. (1-3)");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    foreach (int output in eight)
                        Console.WriteLine(output);
                    break;

                case 2:
                    Array.Reverse(eight);
                    foreach (int output in eight)
                        Console.WriteLine(output);
                    Array.Reverse(eight);
                    break;
                case 3:
                    Console.WriteLine("Enter in a position");
                    int input2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(eight[input2]);
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
        }
    }
}
