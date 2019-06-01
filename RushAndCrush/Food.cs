using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace RushAndCrush
{
    class Food
    {
        public int x, y, w, h;
        public Image pic;

        // TO DO: images needed to be inserted in these rectangles and then placed in the list 
        public Food(int x_, int y_, int w_, int h_ , Image pic_)
        {
            x = x_;
            y = y_;
            w = w_;
            h = h_;
            pic = pic_;

        }
    }
}
