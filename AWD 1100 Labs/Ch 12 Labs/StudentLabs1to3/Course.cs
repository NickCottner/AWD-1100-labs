using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLabs1to3
{
    class Course
    {
        readonly List<Student> students = new List<Student>
        {
            new Student("1234", "Nick", "Cottner", "npcottner@gmail.com"),
            new Student("6419", "Megan" , "Ptak", "mygirl123@charter.net"),
            new Student("7899", "Kelly" , "Berry", "berrygood@att.net"),
            new Student("9032", "Jeff", "Scott", "jscott@ranken.edu"),
            new Student("2109", "Luke", "Muich", "thebestman@centurylink.net")
        };
    }
}
