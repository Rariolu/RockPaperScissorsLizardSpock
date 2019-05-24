using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public class HumanPlayer : Player
    {
        public override Gesture GetGesture()
        {
            return Util.GetUserGesture();
        }
    }
}