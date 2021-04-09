using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2_Photos
{
    public class MattedPhoto : Photo
    {
        //Color enumerator
        public enum Color
        { 
            Black = 0,
            Red = 1,
            Green = 2,
            Blue = 4,
            White = 7
        }
        //Instance Variable
        Color _theColor;

        //Constructor
        public MattedPhoto(double width, double height, Color color) : base (width, height)
        {
            this._theColor = color;
        }

        //Getter/Setter
        public Color TheColor
        {
            get
            {
                return _theColor;
            }
            set
            {
                _theColor = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + " Matted " + TheColor.ToString();
        }


    }
}
