namespace Paddys.Fifa.Leaderboard.Data.Model
{
    public class Game
    {
        public int Id { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
    }
}
