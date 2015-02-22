using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;
using Nancy.Validation;
using Paddys.Fifa.Leaderboard.ViewModels;

namespace Paddys.Fifa.Leaderboard.Modules
{
	public class PlayerModule : NancyModule
	{
		public PlayerModule() : base("/player")
		{
			Get["/addplayer"] = _ => View["Shared/_AddPlayer"];

			Post["/addplayer"] = _ =>
				{
					var viewModel = this.BindAndValidate<PlayerDetails>();
					var model = this.Bind<PlayerDetails>();
					var result = this.Validate(model);

					if (!result.IsValid)
					{
						return "Error";
					}

					return View["Shared/_AddPlayer"];
				};
		}
	}
}