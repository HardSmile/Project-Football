
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Football.Models
{
    public class Game
    {
        public int Id { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public int? HomeScore { get; set; }
        public int? AwayScore { get; set; }
        [NotMapped]
        public GameResult Result 
        {
            get {
                if (!HomeScore.HasValue && !AwayScore.HasValue)
                {
                    return GameResult.NotFinished;
                }
                else if (HomeScore > AwayScore)
                {
                    return GameResult.HomeWon;
                }
                else if (AwayScore > HomeScore)
                {
                    return GameResult.AwayWon;
                }
                else
                {
                    return GameResult.Draw;
                }
                }
                }

    }
}
