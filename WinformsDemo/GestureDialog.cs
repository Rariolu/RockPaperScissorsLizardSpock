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
    public partial class GestureDialog : Form
    {
        //Images:
        //https://vignette.wikia.nocookie.net/bigbangtheory/images/7/7d/RPSLS.png/revision/latest?cb=20120822205915
        
        public GestureDialog()
        {
            InitializeComponent();
        }
        Gesture gesture;
        public Gesture GestureResult
        {
            get
            {
                return gesture;
            }
        }
        private void btnScissors_Click(object sender, EventArgs e)
        {
            SetGesture(Gesture.SCISSORS);
        }
        private void btnPaper_Click(object sender, EventArgs e)
        {
            SetGesture(Gesture.PAPER);
        }
        private void btnRock_Click(object sender, EventArgs e)
        {
            SetGesture(Gesture.ROCK);
        }
        private void btnLizard_Click(object sender, EventArgs e)
        {
            SetGesture(Gesture.LIZARD);
        }
        private void btnSpock_Click(object sender, EventArgs e)
        {
            SetGesture(Gesture.SPOCK);
        }
        void SetGesture(Gesture gest)
        {
            gesture = gest;
            DialogResult = DialogResult.OK;
        }
        public Gesture GetGesture()
        {
            ShowDialog();
            return GestureResult;
        }
        public static Gesture GetGestureFromDialog()
        {
            return new GestureDialog().GetGesture();
        }
    }
}