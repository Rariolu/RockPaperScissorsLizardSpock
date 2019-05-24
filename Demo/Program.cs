using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RockPaperScissorsLizardSpock;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Util.StringOutput = Console.WriteLine;
            Util.SetGestureRetrieval(GetGesture);
            char contine;
            string name1 = GetText("What's player 1's name?");
            string name2 = GetText("What's player 2's name?");
            PlayerType pt1 = GetEnumValue<PlayerType>("Enter valid player type (Human, RandAI, AlwaysRock) for {0}.", name1);//GetPlayerType();
            PlayerType pt2 = GetEnumValue<PlayerType>("Enter valid player type (Human, RandAI, AlwaysRock) for {0}.", name2);//GetPlayerType();
            do
            {
                Game game = new Game(name1, name2, pt1, pt2);
                game.PlayRounds(5);
                Console.WriteLine("Press 'y' to do another. Press something else to exit.");
                contine = Console.ReadKey().KeyChar;
            }
            while (contine == 'y');
            Console.WriteLine("Goodbye.");
        }
        static string GetText(string query)
        {
            Console.Write(query);
            string t = Console.ReadLine();
            Console.WriteLine();
            return t;
        }
        static T GetEnumValue<T>(string message, params object[] args) where T: struct
        {
            if (!typeof(T).IsEnum)
            {
                return default(T);
            }
            string t;
            T val;
            int i = 0;
            do
            {
                Console.Write("{0} {1}", ++i, string.Format(message,args));
                t = Console.ReadLine();
            }
            while (!EnumUtil.EnumTryParse(t, out val));
            Console.WriteLine();
            return val;
        }
        static Gesture GetGesture()
        {
            return GetEnumValue<Gesture>("Enter valid Gesture (Rock, Paper, Scissors, Lizard, Spock):");
        }
    }
}