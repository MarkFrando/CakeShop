using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Address
    {
        string strAddress;
        string strMail;

        public List<string> Mailings { get; set; }

        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public int Mail1 { get; set; }
        public int Mail2 { get; set; }
        public int Mail3 { get; set; }

        public string FullAddress
        {
            get
            {
                strAddress = "";
                strAddress += StreetAddress + ", ";
                strAddress += City + ", ";
                strAddress += Province + " " + PostalCode;
                return strAddress;
            }
            set
            {
                strAddress = value;
            }
        }

        public void AddMail(string m)
        {
            Mailings.Add(m);
        }

        public Address()
        {
            StreetAddress = "";
            City = "";
            PostalCode = "";
            Province = "";
            Mailings = new List<string>();
        }

        public Address(string ad, string ct, string pc, string pr, int m1, int m2, int m3)
        {
            StreetAddress = ad;
            City = ct;
            PostalCode = pc;
            Province = pr;
            Mail1 = m1;
            Mail2 = m2;
            Mail3 = m3;
            Mailings = new List<string>();
        }

        public override String ToString()
        {
            string output;
            if(Mailings.Count == 0)
            {
                output = "";
            }
            else
            {
                output = "\n\nMailings:";
            }
            foreach (string m in Mailings)
            {
                output += "\n" + m;
            }
            return FullAddress + 
                   output + "\n";
        }
    }
}
