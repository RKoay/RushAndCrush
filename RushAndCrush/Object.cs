using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RushAndCrush
{
    class Object
    {
        public int x, y, width, height;
        public Color colour;

        //TEXTURES MIGHT NEED TO BE ADDED TO THE OBJECTS    
        public Object(int x_, int y_, int width_, int height_, Color colour_)
        {
            x = x_;
            y = y_;
            width = width_;
            height = height_;
            colour = colour_;
        }
        
        //moving the chooser to select the items the user wants 
        public void chooserMove(int squareX, int squareY, string direction)
        {
            if (direction == "left")
            {
                x = x - squareX;
            }
            else if (direction == "right")
            {
                x = x + squareX;
            }

            if (direction == "up")
            {
                y = y - squareY;
            }
            else if (direction == "down")
            {
                y = y + squareY;
            }
            
        }

        ////When the chooser collides with side, it will not continue moving through
        //public void ChooserCollision(Object c)
        //{
        //    Rectangle crec = new Rectangle(c.x, c.y, c.width, c.height);

        //    //setting parameters
        //    //collision with left, collision with right 
        //    if (c.x > 670) { c.x = 670; }
        //    if (c.x < 20) { c.x = 20; }
        //    //collision with up, collision with down
        //    if (c.y > 917) { c.y = 917; }
        //    if (c.y < 735) { c.y = 735; }

           
        //}
    }
}
