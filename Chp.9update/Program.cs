using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp._9update
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars newCar = new Cars("STi", 30);
            Console.WriteLine("The model of the car is {0} and the MPG for the car is {1}", newCar.model, newCar.miles);
            newCar++;
            Console.WriteLine("The model of the car is {0} and the MPG for the car is {1}", newCar.model, newCar.miles);

        }
    }
}
