using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RushAndCrush
{
    class Toppings
    {
        public int x, y, w, h;
        public Color c;
        public string type;
        public Toppings(int x_, int y_, int w_, int h_, Color c_, string type_)
        {
            x = x_;
            y = y_;
            w = w_;
            h = h_;
            c = c_;
            type = type_;
        }
    }
}
