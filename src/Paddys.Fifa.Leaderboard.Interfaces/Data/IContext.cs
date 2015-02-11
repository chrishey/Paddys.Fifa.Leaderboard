using System.Collections.Generic;
using Paddys.Fifa.Leaderboard.Data.Model;

namespace Paddys.Fifa.Leaderboard.Interfaces.Data
{
    public interface IContext
    {
        IList<Game> Games { get; set; }
        IList<Player> Players { get; set; } 
    }
}
