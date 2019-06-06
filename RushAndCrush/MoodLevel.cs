using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RushAndCrush
{
    class MoodLevel
    {
        public Color colour;
        public int x, y, height, width;
        public int levelX, levelY, levelLength, levelHeight;

        public MoodLevel(int x_, int y_, int width_, int height_, int levelX_, int levelY_, int levelLength_, int levelHeight_, Color levelColour_)
        {
            x = x_;
            y = y_;
            
            width = width_;
            height = height_;

            levelX = levelX_;
            levelY = levelY_;
            levelLength = levelLength_;
            levelHeight = levelHeight_;

            colour = levelColour_;

        }

        public void StartLevel(int downLevel)
        {
            //decreasing y values...need to be tested 
            levelY = levelY + downLevel;
            levelHeight = levelHeight - downLevel;
        }

        public void UpMood(int upLevel)
        {
            //Moving the bar up depending...
            levelY = levelY - upLevel;
            levelHeight = levelHeight + upLevel;
        }

        public void DownMood(int downLevel)
        {
            //Moving the bar down depending
            levelY = levelY + downLevel;
            levelHeight = levelHeight - downLevel;
        }
        

    }
}
