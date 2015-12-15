using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp._9update
{
    class Cars
    {
        public string model { get; set; }
        public double miles { get; set; }

        public Cars(string model, double miles)
        {
            this.model = model;
            this.miles = miles;
        }

        public Cars(string model)
        {
            this.model = model;
            miles = 20;
        }

        //overload

        public static Cars operator ++(Cars first)
        {
            first.miles++;
            return first;
        }
    }
}
