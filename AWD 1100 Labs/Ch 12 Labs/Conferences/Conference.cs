using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conferences
{
    class Conference
    {
        string _groupName;
        DateTime _startingDate;
        int _attendees;

        public enum Room
        {
            ROOM_101 = 101,
            ROOM_102 = 102,
            ROOM_201 = 201,
            ROOM_202 = 202,
            ROOM_301 = 301,
            ROOM_302 = 302
        }
        Room _theRoom;

        public Display(int attendees, string groupName, DateTime startingDate, Room room)
        {
            attendees = _attendees;
            groupName = _groupName;
            startingDate = _startingDate;
            room = _theRoom;
        }

    }
}
