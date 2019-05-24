using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public class AlwaysRockPlayer : Player
    {
        public override Gesture GetGesture()
        {
            return Gesture.ROCK;
        }
    }
}