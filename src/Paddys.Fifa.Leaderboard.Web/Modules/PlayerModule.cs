using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;
using Nancy.Validation;
using Paddys.Fifa.Leaderboard.Interfaces.Players;
using Paddys.Fifa.Leaderboard.Models;
using Paddys.Fifa.Leaderboard.ViewModels;

namespace Paddys.Fifa.Leaderboard.Modules
{
	public class PlayerModule : NancyModule
	{
		private readonly IPlayerStoreService _playerStoreService;

		public PlayerModule(IPlayerStoreService playerStoreService)
			: base("/player")
		{
			Get["/addplayer"] = _ =>
				{
					var player = new PlayerDetails();
					return View["Shared/_AddPlayer", player];
				};

			Post["/addplayer"] = _ =>
				{
					var viewModel = this.Bind<PlayerDetails>();
					var result = this.Validate(viewModel);

					if (!result.IsValid)
					{
						return View["Shared/_AddPlayer", viewModel];
					}

					var player = new Player()
						{
							FirstName = viewModel.FirstName,
							Surname = viewModel.Surname,
							PlayerLevel = viewModel.PlayerLevel
						};

					playerStoreService.Add(player);

					return Response.AsRedirect("/");
				};

			Post["/addplayerasync"] = _ =>
			{
				var viewModel = this.Bind<PlayerDetails>();
				var result = this.Validate(viewModel);

				if (!result.IsValid)
				{
					return Response.AsJson(viewModel);
				}

				return Response.AsJson(viewModel, HttpStatusCode.Accepted);
			};
		}
	}
}