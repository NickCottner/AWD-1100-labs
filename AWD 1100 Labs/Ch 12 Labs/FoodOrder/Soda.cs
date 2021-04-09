using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder
{
    class Soda
    {
        const double BASE_PRICE = 1.75;
        const double FLAVOR_PRICE = 0.15;
        SodaFlavor _flavor;
        double _price;

        public enum SodaFlavor
        {
            NONE,
            LIME,
            PEACH,
            MANGO
        }
        public SodaFlavor flavor
        {
            get
            {
                return _flavor;
            }
        }
        public Soda()
        {

        }

        public SodaFlavor AddFlavor
        {
            get
            {
                return _flavor;
            }
        }
    }
}
