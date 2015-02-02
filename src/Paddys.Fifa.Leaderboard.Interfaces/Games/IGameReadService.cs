using System.Collections.Generic;
using Paddys.Fifa.Leaderboard.Data.Model;

namespace Paddys.Fifa.Leaderboard.Interfaces.Games
{
    public interface IGameReadService
    {
        Game GetGame(int id);
        IEnumerable<Game> GetGames(int playerId);
        IEnumerable<Game> GetAllGames();
    }
}
