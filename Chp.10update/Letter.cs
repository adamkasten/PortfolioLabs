using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp._10update
{
    class Letter
    {
        public string NameofRecipient { get; set; }
        public string DateMailed { get; set; }
        //folder

        public Letter() { }

        public Letter(string nameofrecipient, string datemailed)
        {
            NameofRecipient = nameofrecipient;
            DateMailed = datemailed;
        }

        public override string ToString()
        {
            return "This is the Letter class: " + NameofRecipient + " " + DateMailed;
        }
    }
}
