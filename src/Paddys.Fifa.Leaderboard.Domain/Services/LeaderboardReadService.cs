using System.Collections.Generic;
using System.Linq;
using Paddys.Fifa.Leaderboard.Data.Model;
using Paddys.Fifa.Leaderboard.Interfaces.Data;
using Paddys.Fifa.Leaderboard.Interfaces.Leaderboard;

namespace Paddys.Fifa.Leaderboard.Domain.Services
{
    public class LeaderboardReadService : ILeaderboardReadService
    {
        private readonly IContext _context;

        public LeaderboardReadService(IContext context)
        {
            _context = context;
        }

        public IEnumerable<Player> GetLeaderboard()
        {
            return _context.Players.OrderByDescending(p => p.Score);
        }
    }
}