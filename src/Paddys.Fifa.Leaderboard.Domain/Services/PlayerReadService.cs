using System.Collections.Generic;
using Paddys.Fifa.Leaderboard.Data.Model;
using Paddys.Fifa.Leaderboard.Interfaces.Data;
using Paddys.Fifa.Leaderboard.Interfaces.Players;

namespace Paddys.Fifa.Leaderboard.Domain.Services
{
	public class PlayerReadService : IPlayerReadService
	{
		private readonly IContext _context;

		public PlayerReadService(IContext context)
		{
			_context = context;
		}

		public Player GetPlayer(int id)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<Player> GetAllPlayers()
		{
			return _context.Players;
		}
	}
}
