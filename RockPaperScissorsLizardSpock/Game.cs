using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        Player player1;
        Player player2;
        public Game(string name1, string name2) : this(name1,name2,PlayerType.Human,PlayerType.RandAI)
        {

        }
        public Game(string name1, string name2, PlayerType pt1, PlayerType pt2)
        {
            player1 = Util.GeneratePlayer(pt1);
            player1.Name = name1;
            player2 = Util.GeneratePlayer(pt2);
            player2.Name = name2;
        }
        public void PlayRounds(int rounds)
        {
            for (int i = 0; i < rounds; i++)
            {
                PlayRound();
                Util.GenerateOutput("{0}: {1}; {2}: {3};\n",player1.Name,player1.Points,player2.Name,player2.Points);
                int remaining = rounds - (i + 1);
                int p1 = player1.Points;
                int p2 = player2.Points;
                if (p1 != p2)
                {
                    int mn = p1 < p2 ? p1 : p2;
                    int mx = p1 > p2 ? p1 : p2;
                    if (mn + remaining < mx)
                    {
                        break;
                    }
                }
            }
            Util.GenerateOutput("Game concluded.");
            if (player1.Points != player2.Points)
            {
                Util.GenerateOutput("{0} {1} {2} won.", player1, player2, Util.SuperiorPlayer(player1, player2).Name);
            }
            else
            {
                Util.GenerateOutput("Tie.");
            }
        }
        public RoundResult PlayRound()
        {
            Gesture gest1 = player1.GetGesture();
            Gesture gest2 = player2.GetGesture();
            RoundResult result = Util.GetResult(gest1, gest2);
            
            //TODO: Perhaps a text output here.
            Util.GenerateOutput("{0}: {1}; {2}: {3};\n", player1.Name, gest1, player2.Name, gest2);
            Util.GenerateOutput("{0}\n",Util.GetMessage(gest1, gest2));

            switch (result)
            {
                case RoundResult.PLAYER_ONE_WIN:
                    player1.IncrementPoints();
                    break;
                case RoundResult.PLAYER_TWO_WIN:
                    player2.IncrementPoints();
                    break;
            }

            return result;
        }
    }
}