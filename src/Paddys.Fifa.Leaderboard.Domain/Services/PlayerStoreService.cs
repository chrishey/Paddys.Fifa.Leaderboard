using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paddys.Fifa.Leaderboard.Models;
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

		public void Add(Player player)
		{
			var data = new Data.Model.Player()
				{
					Id = 1,
					FirstName = player.FirstName,
					Surname = player.Surname,
					Coefficient = player.PlayerLevel //needs work to figure out coefficient from a rating between 1 - 10.
				};

			_context.Players.Add(data);
		}

		public void Save(Player player)
		{
			throw new NotImplementedException();
		}
	}
}