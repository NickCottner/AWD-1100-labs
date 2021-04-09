using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder
{
    class Sundae
    {
        const double BASE_PRICE = 4.50;
        const double TOPPING_PRICE = 0.50;
        SundaeTopping _toppings;
        int _toppingCount;
        double _price;
        public enum SundaeTopping
        {
            NONE,
            SPRINKLES,
            NUTS,
            CHOCOLATE_SYRUP,
        }
        public Sundae()
        { 
        }
        public int ToppingCount
        {
            get
            {
                return _toppingCount;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }
        public SundaeTopping AddToppings
        {
            get
            {
                return _toppings;
            }
        }

    }
}


