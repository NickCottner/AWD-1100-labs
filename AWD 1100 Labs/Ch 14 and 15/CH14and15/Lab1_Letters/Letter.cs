using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Letters
{
    public class Letter
    {
        // Instance Variables
        string _recipient;
        DateTime _sentDate;
        readonly double _price;

        // Constructor
        public Letter(string recipient, DateTime sentDate)
        {
            _recipient = recipient;
            _sentDate = sentDate;
        }
        // getters
        public string Recipient
        {
            get
            {
                return _recipient;
            }
        }
        public DateTime SentDate
        {
            get
            {
                return _sentDate;
            }
        }
        public virtual double Price
        {
            get
            {
                return 0.50;
            }
        }

        public override string ToString()
        {
            return SentDate.ToString("ddMMMyyyy") + ", " + Recipient + ", " + Price.ToString("c");
        }

    }
}
