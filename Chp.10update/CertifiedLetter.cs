using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp._10update
{
    class CertifiedLetter : Letter
    {
        public int TrackingNumber { get; set; }
        new public string NameofRecipient { get; set; }
        new public string DateMailed { get; set; }

        public CertifiedLetter(string nameofrecipient, string datemailed, int trackingnumber)
        {
            NameofRecipient = nameofrecipient;
            DateMailed = datemailed;
            TrackingNumber = trackingnumber;
        }
        public override string ToString()
        {
            return "This is the CertifiedLetter class: " + NameofRecipient + " " + DateMailed + " " + TrackingNumber;
        }
    }
}
