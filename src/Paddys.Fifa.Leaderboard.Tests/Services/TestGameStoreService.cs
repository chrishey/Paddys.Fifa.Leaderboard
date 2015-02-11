using Paddys.Fifa.Leaderboard.Data.Model;
using Paddys.Fifa.Leaderboard.Interfaces.Data;
using Paddys.Fifa.Leaderboard.Interfaces.Games;

namespace Paddys.Fifa.Leaderboard.Tests.Services
{
    public class TestGameStoreService : IGameStoreService
    {
        private readonly IContext _context;

        public TestGameStoreService(IContext context)
        {
            _context = context;
        }

        public void Add(Game game)
        {
            _context.Games.Add(game);
        }

        public void Save()
        {
            return;
        }
    }
}
