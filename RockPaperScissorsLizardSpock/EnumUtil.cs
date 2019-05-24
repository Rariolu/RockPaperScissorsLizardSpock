using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public static class EnumUtil
    {
        public static bool EnumTryParse<T>(string text, out T val) where T : struct
        {
            val = default(T);
            Type type = typeof(T);
            if (!type.IsEnum)
            {
                return false;
            }
            foreach (T t in Enum.GetValues(type))
            {
                if (t.NormalisedString() == text.NormalisedString())
                {
                    val = t;
                    return true;
                }
            }
            return false;
        }
    }
    public enum Gesture
    {
        ROCK,
        PAPER,
        SCISSORS,
        LIZARD,
        SPOCK
    }
    public enum RoundResult
    {
        TIE,
        PLAYER_ONE_WIN,
        PLAYER_TWO_WIN
    }
    public enum PlayerType
    {
        Human,
        RandAI,
        AlwaysRock
    }
}