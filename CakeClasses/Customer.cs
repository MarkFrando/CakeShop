using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Customer
    {
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
            FirstName = "";
            LastName = "";
        }

        public Customer(string f, string l)
        {
            FirstName = f;
            LastName = l;
        }

        public override String ToString()
        {
            return FirstName + " " + LastName + "!";
        }
    }
}
