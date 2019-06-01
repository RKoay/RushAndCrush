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
    public partial class MainMenu : UserControl
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //move to game screen if play button is clicked
            Form f = this.FindForm();
            f.Controls.Remove(value: this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);

            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            gs.Focus();
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            //move to instruction screen if instruction button is clicked
            Form f = this.FindForm();
            f.Controls.Remove(value: this);
            InstructionScreen instr = new InstructionScreen();
            f.Controls.Add(instr);

            instr.Location = new Point((f.Width - instr.Width) / 2, (f.Height - instr.Height) / 2);
        }
        

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            //move to high score screen if high score button is clicked
            Form f = this.FindForm();
            f.Controls.Remove(value: this);
            HighScoreScreen hs = new HighScoreScreen();
            f.Controls.Add(hs);

            hs.Location = new Point((f.Width - hs.Width) / 2, (f.Height - hs.Height) / 2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //if exit button is clicked, exit the game 
            Application.Exit();
        }

        
    }
}
