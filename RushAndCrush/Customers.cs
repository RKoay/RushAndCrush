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
    class Customers
    {
        public int x, y, w, h;
        public Image pic;

        public Customers(int x_, int y_, int w_, int h_, Image pic_)
        {
            x = x_;
            y = y_;
            w = w_;
            h = h_;
            pic = pic_;
        }

        public void CustoMove()
        {
            //until x, y reaches a certain #, 
            //this method wil be stopped and interaction with customers will begin 
            x = x - 20;
            w = w + 20;
            y = y - 20;
            h = h + 20;

        }
        
    }
}
