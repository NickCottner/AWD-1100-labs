using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Letters
{
   public class CertifiedLetter : Letter
    {
        // intance variable
        string _trackingNumber;

        // Constructor
        public CertifiedLetter(string recipient, DateTime sentDate, string trackingNumber ) : base (recipient,sentDate)
        {
            _trackingNumber = trackingNumber;
        }
       // Getters
        public string TrackingNumber
        {
            get
            {
                return _trackingNumber;
            }
        }
        public override double Price
        {
            get
            {
                return 0.65;
            }
        }
        public override string ToString()
        {
            return base.SentDate.ToString("ddMMMyyyy") + ", " + base.Recipient + ", " + Price.ToString("c");
        }

    }
}
