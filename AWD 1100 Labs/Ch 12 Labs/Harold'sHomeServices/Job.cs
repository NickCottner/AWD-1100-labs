using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harold_sHomeServices
{
    class Job
    {
        double TRIP_FEE = 35;
        string _description;
        double _hoursToComplete;
        double _hourlyRate;
        double _totalFee;

        public Job(string description, double hoursToComplete, double hourlyRate)
        {
            _description = description;

            _hoursToComplete = hoursToComplete;

            _hourlyRate = hourlyRate;
        }
        public string GetDescription() => _description;

        public double GetHoursToComplete() => _hoursToComplete;

        public double GetHourlyFee() => _hoursToComplete;

        public double TotalFee
        {
            get
            {
                double totalFee = (_hoursToComplete * _hourlyRate) + TRIP_FEE;
                double temp = totalFee;
                _totalFee = (totalFee == 0) ? temp : ++temp;
                return _totalFee;
            }
        }


    }
}
