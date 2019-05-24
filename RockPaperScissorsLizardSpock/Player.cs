using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Player
    {
        int points = 0;
        public int Points
        {
            get
            {
                return points;
            }
        }
        string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void IncrementPoints()
        {
            points++;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1};", Name, Points);
        }
        public abstract Gesture GetGesture();
    }
}