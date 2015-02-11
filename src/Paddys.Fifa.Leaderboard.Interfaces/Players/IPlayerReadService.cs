using System.Collections.Generic;
using Paddys.Fifa.Leaderboard.Data.Model;

namespace Paddys.Fifa.Leaderboard.Interfaces.Players
{
    public interface IPlayerReadService
    {
        Player GetPlayer(int id);
        IEnumerable<Player> GetAllPlayers();
    }
}
