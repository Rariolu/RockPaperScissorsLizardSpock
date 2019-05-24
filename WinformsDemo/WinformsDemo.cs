using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RockPaperScissorsLizardSpock;

namespace WinformsDemo
{
    public partial class RPSLSpWinformsDemo : Form
    {
        public RPSLSpWinformsDemo()
        {
            InitializeComponent();
            Console.WriteLine("{0} {1}", Player1Type, Player2Type);
        }
        public string Player1Name
        {
            get
            {
                return tbPlayer1.Text;
            }
        }
        public string Player2Name
        {
            get
            {
                return tbPlayer2.Text;
            }
        }
        public PlayerType Player1Type
        {
            get
            {
                if (rbHuman1.Checked)
                {
                    return PlayerType.Human;
                }
                if (rbRandAI1.Checked)
                {
                    return PlayerType.RandAI;
                }
                //else
                return PlayerType.AlwaysRock; 
            }
        }
        public PlayerType Player2Type
        {
            get
            {
                if (rbHuman2.Checked)
                {
                    return PlayerType.Human;
                }
                if (rbRandAI2.Checked)
                {
                    return PlayerType.RandAI;
                }
                //else
                return PlayerType.AlwaysRock;
            }
        }
    }
}