using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2_Photos
{
    public class Photo
    {
        //Instancw Variables
        double _width;
        double _height;

       //Constructor
        public Photo(double width, double height)
        {
            this._width = width;
            this._height = height;
        }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public override string ToString()
        {
            return (Width + " x " + Height);
        }
    }
}
