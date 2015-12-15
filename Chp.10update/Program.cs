using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp._10update
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter L1 = new Letter("Ron", "July 6th");
            CertifiedLetter CL1 = new CertifiedLetter("Jim", "Febuary 9th", 123234);
            Console.WriteLine(L1.ToString());
            Console.WriteLine(CL1.ToString());
        }
    }
}
