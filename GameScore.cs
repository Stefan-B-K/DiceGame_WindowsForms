using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSP_0463_imd_MyProject
{
    internal static class GameScore
    {
        public const int MaxPoints1Dice = 25;
        public const int MaxPoints2Dice = 50;
        public const int MinPoints = 10;
        public const int MaxRounds = 10;
        public const int MinRounds = 1;

        public static int Turn = 1;
        public static int Round = 1;
        private static List<int> ScoreUser = new() { };
        private static List<int> ScoreComp = new() { };

        public static void AddScore(PlayerTurn player, int score)
        {
            if (player == PlayerTurn.User)
                ScoreUser.Add(score);
            else
                ScoreComp.Add(score);
        }

        public static int TotalScore(PlayerTurn player)
        {
            return player == PlayerTurn.User ? ScoreUser.Sum() : ScoreComp.Sum();
        }

        public static void ClearScores()
        {
            ScoreUser.Clear();
            ScoreComp.Clear();
            Round = 1;
            Turn = 1;
        }
    }
}
