﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    class FlashCard
    {
        //Instance variables
        private string _term;
        private string _definition;

        //Constructor
        public FlashCard(string term, string definition)
        {
            _term = term;
            _definition = definition;
        }

        //Create getters
        public string GetTerm() => _term;

        public string GetDefinition() => _definition;
    }    
}
