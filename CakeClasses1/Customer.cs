using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Customer
    {
        public Address address { get; set; }
        string strFirstName;
        string strLastName;

        public string FirstName
        {
            get { return strFirstName; }
            set { strFirstName = value; }
        }

        public string LastName
        {
            get { return strLastName; }
            set { strLastName = value; }
        }

        public Customer()
        {
            address = new Address();
            FirstName = "";
            LastName = "";
        }

        public Customer(string f, string l, string ad, string ct, string pc, string pr, int m1, int m2, int m3)
        {
            address = new Address(ad, ct, pc, pr, m1, m2, m3);
            FirstName = f;
            LastName = l;
        }

        public override String ToString()
        {
            return FirstName + " " + LastName + "!\n";
        }
    }
}
