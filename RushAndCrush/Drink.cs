using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RushAndCrush
{
    class Drink
    {

        public int x, y, w, h;
        public Image pic;
   
        //TO DO: Place the images into the rectangles 
        public Drink(int x_, int y_, int w_, int h_, Image pic_)
        {
            x = x_;
            y = y_;
            w = w_;
            h = h_;
            pic = pic_;
        }

    }
}
