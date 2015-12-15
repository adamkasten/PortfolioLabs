using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp._5update
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 11; x++)
            {
                for (int y = 1; y < 11; y++)
                {
                    Console.Write(x * y);
                }
                Console.WriteLine();
            }
        }
    }
}
