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
    public partial class HighScoreScreen : UserControl
    {
        List<HighScores> arrangingPurposes = new List<HighScores>();
        public HighScoreScreen()
        {
            InitializeComponent();
            //displaying the high scores here 

            foreach (HighScores h in Form1.topearnings)
            {
                double arrangeNum = Convert.ToDouble(h.highScores);
                HighScores s = new HighScores(arrangeNum);
                arrangingPurposes.Add(s);
            }

            //Sorting the code
            arrangingPurposes.Sort(delegate (HighScores x, HighScores y)
            {
                return y.arrangeScores.CompareTo(x.arrangeScores);
            });

            //removing scores at destined number 
            if (arrangingPurposes.Count() > 5)
            {
                arrangingPurposes.RemoveAt(5);
            }

            int labellingScores = 1;
            foreach (HighScores s in arrangingPurposes)
            {
                //TO DO: only display top 5 high scores with numbers beside them
                //Remove the scores after 5 high scores 

                highScores.Text += "\n" + labellingScores++ + ". $ " + s.arrangeScores + "\n";
                
            }
            
        }

        private void HighScoreScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Form f = this.FindForm();
                    f.Controls.Remove(value: this);
                    MainMenu mm = new MainMenu();
                    f.Controls.Add(mm);

                    mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
                    mm.Focus();
                    break;
            }
        }

        private void HighScoreScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    break;
            }
        }
    }
}
