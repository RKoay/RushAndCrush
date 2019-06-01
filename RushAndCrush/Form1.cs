using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RushAndCrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Direct to Main Menu 
            MainMenu ms = new MainMenu();
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
