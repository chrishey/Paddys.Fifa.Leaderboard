using System.Collections.Generic;
using Paddys.Fifa.Leaderboard.Data.Model;

namespace Paddys.Fifa.Leaderboard.Interfaces.Leaderboard
{
    public interface ILeaderboardReadService
    {
        IEnumerable<Player> GetLeaderboard();
    }
}
