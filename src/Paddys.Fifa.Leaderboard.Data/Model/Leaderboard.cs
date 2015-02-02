using System.Linq;

namespace Paddys.Fifa.Leaderboard.Data.Model
{
    public class Leaderboard
    {
        public IOrderedEnumerable<Player> Rankings { get; set; } 
    }
}
