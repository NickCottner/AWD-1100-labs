using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEstimator
{
    class Room
    {
        //INitialize vairables
        private string _name;
        private int _width;
        private int _length;
        private int _area;
        private int _boxes;

        //Constructors
        public Room(string name, int width, int length, int area, int boxes)
        {
            _name = name;
            _width = width;
            _length = length;
            _area = area;
            _boxes = boxes;
        }

        //Getters
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
        }
        public int Length
        {
            get
            {
                return _length;
            }
        }
        public int Area
        {
            get
            {
                return _area;
            }
        }
        public int Boxes
        {
            get
            {
                int temp = (_area / 12);
                _boxes = (_area % 12 == 0) ? temp : ++temp;
                return _area;
            }
        }
    }
}
