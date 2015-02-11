using Paddys.Fifa.Leaderboard.Data.Model;

namespace Paddys.Fifa.Leaderboard.Interfaces.Players
{
    public interface IPlayerStoreService
    {
        void Add(Player player);
        void Save(Player player);
    }
}
