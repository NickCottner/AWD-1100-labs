using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder
{
    class Order
    {
        private string _name;
        private bool _sundae;
        private bool _soda;

        public Order(string name, bool hasSundae, bool hasSoda)
        {
            _name = name;
            _sundae = hasSundae;
            _soda = hasSoda;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public bool Sundae
        {
            get
            {
                return _sundae;
            }
        }
        public bool Soda
        {
            get
            {
                return _soda;
            }
        }



    }
}
