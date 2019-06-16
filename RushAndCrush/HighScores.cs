using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RushAndCrush
{
    public class HighScores
    {
        public string highScores;
        public double arrangeScores;
        public HighScores(string highscores_)
        {
            highScores = highscores_;

        }
        public HighScores(double arrangeScores_)
        {
            arrangeScores = arrangeScores_;
        }
    }
}
