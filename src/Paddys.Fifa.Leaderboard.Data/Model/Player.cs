using System;

namespace Paddys.Fifa.Leaderboard.Data.Model
{
    public class Player
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int PlayerLevel { get; set; }
        public double Coefficient { get; set; }
        public int Score { get; set; }
    }
}
