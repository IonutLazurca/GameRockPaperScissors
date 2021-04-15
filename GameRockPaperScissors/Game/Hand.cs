using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameRockPaperScissors.Game
{
    public class Hand
    {
        public RockPaperScissors Selection { get; set; }
        public RockPaperScissors WinAgainst { get; set; }
        public RockPaperScissors LoseAgainst { get; set; }
        public string ImageUrl { get; set; }

        public GameResult PlayAgainst(Hand opponent)
        {
            if(Selection == opponent.Selection)
            {
                return GameResult.Draw;
            }
            else if(LoseAgainst == opponent.Selection)
            {
                return GameResult.Loss;
            }
            return GameResult.Victory;
        }
    }
}
