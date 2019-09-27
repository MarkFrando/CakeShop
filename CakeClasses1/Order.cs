using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Order
    {
        public Cake cake { get; set; }

        public List<string> lstCakes;

        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        public Order()
        {
            lstCakes = new List<string>();
        }

        public void AddCakes(bool an, bool gr, bool we, bool ch, bool va, bool ba, bool t1, bool t2, bool t3)
        {
            cake = new Cake(an, gr, we, ch, va, ba, t1, t2, t3);
            lstCakes.Add(cake.ToString());
            Quantity += 1;
            TotalPrice += cake.cakeType.GetPrice();
        }

        public void AddCakes(int i)
        {
            cake = new Cake(i);
            lstCakes.Add(cake.ToString());
            Quantity += 1;
            TotalPrice += cake.cakeType.GetPrice();
        }

        public String ViewOrder()
        {
            string strOutput = "";
            foreach (string c in lstCakes)
            {
                strOutput += c.ToString();
            }
            return strOutput;
        }

        public override String ToString()
        {
            return "\nYou have ordered " + Quantity + " cake(s)" + "\n" +
                   "\n" + ViewOrder() + 
                   "Your final total cost amounts to " + TotalPrice.ToString("C") + ".";
        }
    }
}
