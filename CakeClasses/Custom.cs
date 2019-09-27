using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Custom : Traditional
    {
        private const decimal decCAKE = 20;
        private const decimal decTIER1 = 3;
        private const decimal decTIER2 = 6;
        private const decimal decTIER3 = 9;
        const decimal decTAX = 1.13m;
        string strCustomCake;
        double price;

        public bool Anniversary { get; set; }
        public bool Graduation { get; set; }
        public bool Wedding { get; set; }
        public bool Chocolate { get; set; }
        public bool Vanilla { get; set; }
        public bool Banana { get; set; }
        public bool Tier1 { get; set; }
        public bool Tier2 { get; set; }
        public bool Tier3 { get; set; }

        public double Price
        {
            get
            {
                price = 0;
                if (Tier1)
                {
                    Price = (double)((decCAKE + decTIER1) * decTAX);
                }
                if (Tier2)
                {
                    Price = (double)((decCAKE + decTIER2) * decTAX);
                }
                if (Tier3)
                {
                    Price = (double)((decCAKE + decTIER3) * decTAX);
                }
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string CustomCake
        {
            get
            {
                strCustomCake = "\n1 ";
                if (Anniversary)
                {
                    strCustomCake += "Anniversary cake, ";
                }
                if (Graduation)
                {
                    strCustomCake += "Graduation cake, ";
                }
                if (Wedding)
                {
                    strCustomCake += "Wedding cake, ";
                }
                if (Chocolate)
                {
                    strCustomCake += "Chocolate flavoured with ";
                }
                if (Vanilla)
                {
                    strCustomCake += "Vanilla flavoured with ";
                }
                if (Banana)
                {
                    strCustomCake += "Banana flavoured with ";
                }
                if (Tier1)
                {
                    strCustomCake += "1 tier for the cost of " + ((decCAKE + decTIER1) * decTAX).ToString("C") + ".\n";
                }
                if (Tier2)
                {
                    strCustomCake += "2 tiers for the cost of " + ((decCAKE + decTIER2) * decTAX).ToString("C") + ".\n";
                }
                if (Tier3)
                {
                    strCustomCake += "3 tiers for the cost of " + ((decCAKE + decTIER3) * decTAX).ToString("C") + ".\n";
                }
                return strCustomCake;
            }
            set
            {
                strCustomCake = value;
            }
        }

        public Custom()
        {
            Anniversary = false;
            Graduation = false;
            Wedding = false;
            Chocolate = false;
            Vanilla = false;
            Banana = false;
            Tier1 = false;
            Tier2 = false;
            Tier3 = false;
        }

        public Custom(bool anniversary, bool graduation, bool wedding, bool chocolate, bool vanilla, bool banana, bool tier1, bool tier2, bool tier3)
        {
            Anniversary = anniversary;
            Graduation = graduation;
            Wedding = wedding;
            Chocolate = chocolate;
            Vanilla = vanilla;
            Banana = banana;
            Tier1 = tier1;
            Tier2 = tier2;
            Tier3 = tier3;
        }

        public double GetPrice()
        {
            return Price;
        }

        public override String ToString()
        {
            return CustomCake;
        }
    }
}
