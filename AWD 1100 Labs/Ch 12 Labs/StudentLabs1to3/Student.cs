using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLabs1to3
{
    class Student
    {
        string _studentId;
        string _firstName;
        string _lastName;
        string _emailAddress;

        public Student(string studentId, string firstName, string lastName, string emailAddress)
        {
            _studentId = studentId;
            _firstName = firstName;
            _lastName = lastName;
            _emailAddress = emailAddress;
        }
        public string studentId => _studentId;
        public string firstName => _firstName;
        public string lastName => _lastName;
        public string emailAddress => _emailAddress;
      
        
    }
}
