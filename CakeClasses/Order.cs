using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Order
    {
        public Customer Customer { get; set; }
        public Cake Cake { get; set; }

        public static int Quantity { get; set; }
        public static double TotalPrice { get; set; }

        public List<string> lstCakes;

        public Order()
        {
            Customer = new Customer();
            Cake = new Cake();
            lstCakes = new List<string>();
        }

        public Order(string f, string l, bool an, bool gr, bool we, bool ch, bool va, bool ba, bool t1, bool t2, bool t3)
        {
            Customer = new Customer(f, l);
            Cake = new Cake(an, gr, we, ch, va, ba, t1, t2, t3);
            Quantity += 1;
            TotalPrice += Cake.CakeType.GetPrice();
        }

        public Order(string f, string l, int i)
        {
            Customer = new Customer(f, l);
            Cake = new Cake(i);
            Quantity += 1;
            TotalPrice += Cake.CakeType.GetPrice();
        }

        public void AddCakes(string c)
        {
            lstCakes.Add(c);
        }

        public String ViewOrder()
        {
            string strOutput = "";
            foreach (string c in lstCakes)
            {
                strOutput = c.ToString();
            }
            return strOutput;
        }

        public override String ToString()
        {
            return Customer.ToString() + "\n" +
                   "\nYou have ordered " + Quantity + "cake(s)" +
                   "\n" + ViewOrder() + "\n" +
                   "\nFor the total Cost of " + TotalPrice.ToString("C") + ".";
        }
    }
}
