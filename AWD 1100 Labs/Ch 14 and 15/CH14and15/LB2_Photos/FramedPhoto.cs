using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2_Photos
{
    public class FramedPhoto : Photo
    {
        //Material Enumerator( = # not really needed cause that's the values by default)
        public enum Material
        {
            Pine = 0,
            Oak = 1,
            Steel = 2,
            Silver = 3,
            Gold = 4
        }
        //Style Enumerator
        public enum Style
        {
            Simple,
            Modern,
            Antique,
            Vintage,
            Ecletic
        }

        //Instance Variables
        Material _theMaterial;
        Style _theStyle;

        //Constructor
        public FramedPhoto(double width, double height, Material material, Style style) : base (width, height)
        {
            this._theMaterial = material;
            this._theStyle = style;
        }

        public Material TheMaterial
        {
            get
            {
                return _theMaterial;
            }
            set
            {
                _theMaterial = value;
            }
        }
        public Style TheStyle
        {
            get
            {
                return _theStyle;
            }
            set
            {
                _theStyle = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + " Framed " + TheMaterial.ToString() + " " + TheStyle.ToString();
        }



    }
}
