using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Traditional
    {
        private const decimal decSTRAWBERRY = 22;
        private const decimal decBLUEBERRY = 20;
        private const decimal decLEMON = 25;
        private const decimal decTIRAMISU = 30;
        const decimal decTAX = 1.13m;
        string strTraditionalCake;
        double price;

        public int Cake { get; set; }
        public double Price
        {
            get
            {
                price = 0;
                if (Cake == 0)
                {
                    Price = (double)(decSTRAWBERRY * decTAX);
                }
                if (Cake == 1)
                {
                    Price = (double)(decBLUEBERRY * decTAX);
                }
                if (Cake == 2)
                {
                    Price = (double)(decLEMON * decTAX);
                }
                if (Cake == 3)
                {
                    Price = (double)(decTIRAMISU * decTAX);
                }
                return price;
            }
            set
            {
                price = value;
            }
        }

        public String TraditionalCake
        {
            get
            {
                strTraditionalCake = "\n1 ";
                if (Cake == 0)
                {
                    strTraditionalCake += "Strawberry Cheese Cake priced at " + decSTRAWBERRY.ToString("C") + " for the cost of " + (decSTRAWBERRY * decTAX).ToString("C") + ".\n";
                    Price = (double)(decSTRAWBERRY * decTAX);
                }
                else if (Cake == 1)
                {
                    strTraditionalCake += "Blueberry Mousse priced at " + decBLUEBERRY.ToString("C") + " for the cost of " + (decBLUEBERRY * decTAX).ToString("C") + ".\n";
                    Price = (double)(decBLUEBERRY * decTAX);
                }
                else if (Cake == 2)
                {
                    strTraditionalCake = "Lemon Velvet Cake priced at Cake " + decLEMON.ToString("C") + " for the cost of " + (decLEMON * decTAX).ToString("C") + ".\n";
                    Price = (double)(decLEMON * decTAX);
                }
                else if (Cake == 3)
                {
                    strTraditionalCake = "Tiramisu priced at " + decTIRAMISU.ToString("C") + " for the cost of " + (decTIRAMISU * decTAX).ToString("C") + ".\n";
                    Price = (double)(decTIRAMISU * decTAX);
                }
                return strTraditionalCake;
            }
            set
            {
                strTraditionalCake = value;
            }
        }

        public Traditional()
        {
            Cake = 0;
        }

        public Traditional(int type)
        {
            Cake = type;
        }

        public double GetPrice()
        {
            return Price;
        }

        public override string ToString()
        {
            return TraditionalCake;
        }
    }
}
