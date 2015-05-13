using System;
using Nancy;
using Nancy.ModelBinding;
using Paddys.Fifa.Leaderboard.Data.Dto;
using Paddys.Fifa.Leaderboard.Data.Model;
using Paddys.Fifa.Leaderboard.Interfaces.Games;

namespace Paddys.Fifa.Leaderboard.Modules
{
	public class GameModule : NancyModule
	{
		private readonly IGameStoreService _gameStoreService;

		public GameModule(IGameStoreService gameStoreService)
		{
			_gameStoreService = gameStoreService;

			Post["/games/add"] = _ => AddGame();
		}

		private dynamic AddGame()
		{
			var request = this.BindAndValidate<NewGame>();

			try
			{
				_gameStoreService.Add(new Game());
				return true;
			}
			catch(Exception)
			{
				// TODO: logging
				return false;
			}
		}
	}
}