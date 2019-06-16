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
    public partial class GameOverScreen : UserControl
    {
        //TO DO: ADD ANIMATIONS TO END SCREEN 
        public GameOverScreen()
        {
            InitializeComponent();

        }

        private void GameOverScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch(e.KeyCode)
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

        private void GameOverScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    break;
            }
        }
    }
}
