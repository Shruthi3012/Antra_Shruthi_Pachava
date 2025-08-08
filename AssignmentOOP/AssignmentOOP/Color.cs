using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    internal class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int  green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 225;
        }

        
       
        public int GetRed()
        {
            return red;
        }
        public void SetRed(int value)
        {
            red = value;
        }
       

        public int GetGreen()
        {
            return green;
        }
        public void SetGreen(int value)
        {
            green = value;
        }

        public int GetBlue()
        {
            return blue;
        }
        public void SetBlue(int value)
        {
            blue = value;
        }

        public int GetAlpha()
        {
            return alpha;
        }
        public void SetAlpha(int value)
        {
            alpha = value;
        }

        public int GrayScale()
        {
            return (red + green + blue) / 3;
        }

    }
}
