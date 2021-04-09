﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBreak
{
    class Game
    {
        //Instance variable
        private readonly string _name;
        private readonly string _publisher;
        private readonly decimal _price;

        //Constructor
        public Game(string name, string publisher, decimal price)
        {
            _name = name;
            _publisher = publisher;
            _price = price;
        }

        //create getters
        public string GetName() => _name;
        public string GetPublisher() => _publisher;
        public decimal GetPrice() => _price;
    }
}
