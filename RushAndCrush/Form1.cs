using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Media;

namespace RushAndCrush
{
    public partial class Form1 : Form
    {
        SoundPlayer backgroundSound = new SoundPlayer(Properties.Resources.backgroundSound); 
        public static List<HighScores> topearnings = new List<HighScores>();
        public Form1()
        {
            InitializeComponent();
            backgroundSound.PlayLooping();
            //loading the scores to be displayed later 
            loadScores();
            //Direct to Main Menu 
            MainMenu ms = new MainMenu();
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }

        public void loadScores()
        {
            //creating Xml reader file 
            XmlReader reader = XmlReader.Create("HighScores.xml", null);
            string e;

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    e = reader.ReadString();

                    HighScores s = new HighScores(e);

                    topearnings.Add(s);
                }
            }

            reader.Close();
        }

    }
}
