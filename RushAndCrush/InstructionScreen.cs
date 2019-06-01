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
    public partial class InstructionScreen : UserControl
    {
        public InstructionScreen()
        {
            InitializeComponent();
            //giving the instructions
            instructions.Text = "WHAT IS THE GOAL OF THE GAME ? \n " +
                "The goal of the game is to earn as much money as possible in order to move on to the next level and win! \n\n" +
                "WHAT ARE THE CONTROL KEYS ? \n" +
                "Use the Arrows key to highlight around in order to navigate the game \n" +
                "Use the Enter key to proceed with the chosen choice \n" +
                "Press Escape key to escape the game at any time \n\n" +
                "HOW TO EARN MORE MONEY IN THE GAME ? \n" +
                "By raising the customers' mood level, users can raise the amount of money the customers will give them \n\n" +
                "HOW TO RAISE THE CUSTOMERS' MOOD LEVEL ? \n" +
                "By ensuring that the food is completed in the shortest amount of time and the correct food is presented to the customers, users can raise the customers' mood level \n\n" +
                "HOW TO MOVE ON TO THE NEXT LEVEL ? \n" +
                "After reaching a certain quota, users are able to move on to the next level \n";

        }

        
    }
}
