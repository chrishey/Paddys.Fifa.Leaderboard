using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using Paddys.Fifa.Leaderboard.Domain.Context;
using Paddys.Fifa.Leaderboard.Domain.Services;
using Paddys.Fifa.Leaderboard.Interfaces.Data;
using Paddys.Fifa.Leaderboard.Interfaces.Players;

namespace Paddys.Fifa.Leaderboard
{
    using Nancy;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper

		protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
		{
			container.Register<IPlayerStoreService, PlayerStoreService>().AsMultiInstance();
			container.Register<IContext, DataContext>().AsMultiInstance();
		}
    }
}