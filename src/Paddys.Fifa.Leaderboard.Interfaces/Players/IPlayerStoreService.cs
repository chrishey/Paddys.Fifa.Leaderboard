using Paddys.Fifa.Leaderboard.Models;

namespace Paddys.Fifa.Leaderboard.Interfaces.Players
{
    public interface IPlayerStoreService
    {
		void Add(Player player);
		void Save(Player player);
    }
}