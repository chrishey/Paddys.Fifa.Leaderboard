using Paddys.Fifa.Leaderboard.Data.Model;
using Paddys.Fifa.Leaderboard.Interfaces.Data;
using Paddys.Fifa.Leaderboard.Interfaces.Games;

namespace Paddys.Fifa.Leaderboard.Domain.Services
{
	public class GameStoreService : IGameStoreService
	{
		private readonly IContext _context;

		public GameStoreService(IContext context)
		{
			_context = context;
		}

		public void Add(Game game)
		{
			throw new System.NotImplementedException();
		}

		public void Save()
		{
			throw new System.NotImplementedException();
		}
	}
}