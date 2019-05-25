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
        static RPSLSpWinformsDemo _instance;
        public static RPSLSpWinformsDemo Instance()
        {
            if (_instance == null)
            {
                return _instance = new RPSLSpWinformsDemo();
            }
            return _instance;
        }
        private RPSLSpWinformsDemo()
        {
            InitializeComponent();
            Util.SetGestureRetrieval(GestureDialog.GetGestureFromDialog);
            Util.StringOutput = WinformsUtil.MessageBoxShow;
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
        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game = new Game(Player1Name, Player2Name, Player1Type, Player2Type);
            game.PlayRounds(itbRounds.Value);
        }
    }
}