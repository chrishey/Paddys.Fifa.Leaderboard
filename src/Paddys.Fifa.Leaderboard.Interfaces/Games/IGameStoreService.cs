using Paddys.Fifa.Leaderboard.Data.Model;

namespace Paddys.Fifa.Leaderboard.Interfaces.Games
{
    public interface IGameStoreService
    {
        void Add(Game game);
        void Save();
    }
}
