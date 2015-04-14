using System;
using Paddys.Fifa.Leaderboard.Interfaces.Data;
using Paddys.Fifa.Leaderboard.Interfaces.Players;

namespace Paddys.Fifa.Leaderboard.Domain.Services
{
	public class PlayerStoreService : IPlayerStoreService
	{
		private readonly IContext _context;

		public PlayerStoreService(IContext context)
		{
			_context = context;
		}

		public void Add(Data.Model.Player player)
		{
			player.Id = Guid.NewGuid();
		    player.Coefficient = 1.5; // default out the co-efficient to something in the middle?

			_context.Players.Add(player);
		}

		public void Save(Data.Model.Player player)
		{
			throw new NotImplementedException();
		}
	}
}