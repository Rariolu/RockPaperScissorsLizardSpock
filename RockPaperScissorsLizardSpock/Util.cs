using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public delegate Gesture GestureRetrieval();
    public delegate void Output(string text);
    public static class Util
    {
        static Random rand = new Random();
        static GestureRetrieval GestureRetrieval;
        public static Output StringOutput;
        public static void GenerateOutput(string text,params object[] args)
        {
            if (StringOutput != null)
            {
                StringOutput(string.Format(text,args));
            }
        }
        public static void SetGestureRetrieval(GestureRetrieval gr)
        {
            GestureRetrieval = gr;
        }
        public static Gesture GetUserGesture()
        {
            if (GestureRetrieval != null)
            {
                return GestureRetrieval();
            }
            return default(Gesture);
        }
        static Gesture[] gestures = new Gesture[0];
        public static Gesture[] Gestures
        {
            get
            {
                if (gestures.Length < 1)
                {
                    Array vals = Enum.GetValues(typeof(Gesture));
                    return gestures = vals.Cast<Gesture>().ToArray();
                }
                return gestures;
            }
        }
        static Dictionary<GestVec, RoundResult> gestureComparisonResults = new Dictionary<GestVec, RoundResult>()
        {
            //Player one wins
            {new GestVec(Gesture.SCISSORS,Gesture.PAPER),RoundResult.PLAYER_ONE_WIN},
            {new GestVec(Gesture.PAPER,Gesture.ROCK),RoundResult.PLAYER_ONE_WIN},
            {new GestVec(Gesture.ROCK,Gesture.LIZARD),RoundResult.PLAYER_ONE_WIN},
            {new GestVec(Gesture.LIZARD,Gesture.SPOCK),RoundResult.PLAYER_ONE_WIN},
            {new GestVec(Gesture.SPOCK,Gesture.SCISSORS),RoundResult.PLAYER_ONE_WIN},
            {new GestVec(Gesture.SCISSORS,Gesture.LIZARD),RoundResult.PLAYER_ONE_WIN},
            {new GestVec(Gesture.PAPER,Gesture.SPOCK),RoundResult.PLAYER_ONE_WIN},
            {new GestVec(Gesture.ROCK, Gesture.SCISSORS), RoundResult.PLAYER_ONE_WIN},
            {new GestVec(Gesture.LIZARD,Gesture.PAPER), RoundResult.PLAYER_ONE_WIN},
            {new GestVec(Gesture.SPOCK,Gesture.ROCK), RoundResult.PLAYER_ONE_WIN},
        };
        static Dictionary<GestVec, string> messages = new Dictionary<GestVec, string>()
        {
            {new GestVec(Gesture.SCISSORS,Gesture.PAPER),"Scissors cuts Paper."},
            {new GestVec(Gesture.PAPER,Gesture.ROCK),"Paper covers Rock."},
            {new GestVec(Gesture.ROCK,Gesture.LIZARD),"Rock crushes Lizard."},
            {new GestVec(Gesture.LIZARD,Gesture.SPOCK),"Lizard poisons Spock."},
            {new GestVec(Gesture.SPOCK,Gesture.SCISSORS),"Spock smashes Scissors."},
            {new GestVec(Gesture.SCISSORS,Gesture.LIZARD),"Scissors decapitates Lizard."},
            {new GestVec(Gesture.PAPER,Gesture.SPOCK),"Paper disproves Spock."},
            {new GestVec(Gesture.ROCK, Gesture.SCISSORS), "Rock blunts Scissors."},
            {new GestVec(Gesture.LIZARD,Gesture.PAPER), "Lizard eats Paper."},
            {new GestVec(Gesture.SPOCK,Gesture.ROCK), "Spock vapourises Rock."},
        };
        public static string GetMessage(Gesture a, Gesture b)
        {
            GestVec gv = new GestVec(a, b);
            if (messages.ContainsKey(gv))
            {
                return messages[gv];
            }
            if (a == b)
            {
                messages.Add(gv, "The elements are at peace with each other.");
                return messages[gv];
            }
            GestVec opp = gv.Opposite();
            if (messages.ContainsKey(opp))
            {
                string m = messages[opp];
                messages.Add(gv, m);
                return m;
            }
            return "";
        }
        public static RoundResult Opposite(this RoundResult result)
        {
            return result == RoundResult.TIE ? RoundResult.TIE :
            (
                result == RoundResult.PLAYER_ONE_WIN ? RoundResult.PLAYER_TWO_WIN : RoundResult.PLAYER_ONE_WIN
            );
        }
        public static RoundResult GetResult(Gesture a, Gesture b)
        {
            if (a == b)
            {
                return RoundResult.TIE;
            }
            GestVec gv = new GestVec(a, b);
            if (gestureComparisonResults.ContainsKey(gv))
            {
                return gestureComparisonResults[gv];
            }
            GestVec opp = gv.Opposite();
            if (gestureComparisonResults.ContainsKey(opp))
            {
                gestureComparisonResults.Add(gv, gestureComparisonResults[opp].Opposite());
                return gestureComparisonResults[gv];
            }
            return RoundResult.TIE;
        }
        public static T GetRandomElement<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() < 1)
            {
                return default(T);
            }
            return collection.ElementAt(rand.Next(collection.Count()));
        }
        public static string NormalisedString(this object text)
        {
            return text.ToString().ToLower().Trim();
        }
        public static Player GeneratePlayer(PlayerType pt)
        {
            switch (pt)
            {
                case PlayerType.Human:
                    return new HumanPlayer();
                case PlayerType.RandAI:
                    return new RandAIPlayer();
                case PlayerType.AlwaysRock:
                    return new AlwaysRockPlayer();
            }
            throw GenerateFormattedException("Player type \"{0}\" is somehow unprecedented.",pt);
        }
        public static Exception GenerateFormattedException(string format, params object[] args)
        {
            return new Exception(String.Format(format, args));
        }
        public static Player SuperiorPlayer(Player p1, Player p2)
        {
            return p1.Points > p2.Points ? p1 : p2;
        }
    }
    internal struct GestVec
    {
        Gesture gestA;
        Gesture gestB;
        public GestVec(Gesture a, Gesture b)
        {
            gestA = a;
            gestB = b;
        }
        public GestVec Opposite()
        {
            return new GestVec(gestB,gestA);
        }
        public static bool operator ==(GestVec a, GestVec b)
        {
            return a.gestA == b.gestA && a.gestB == b.gestB;
        }
        public static bool operator !=(GestVec a, GestVec b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            if (obj is GestVec)
            {
                return this == (GestVec)obj;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}