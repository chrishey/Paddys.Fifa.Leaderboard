using Nancy.Bootstrapper;
using Paddys.Fifa.Leaderboard.Interfaces.Data;

namespace Paddys.Fifa.Leaderboard.Startup
{
    public class DbPersistChanges : IRequestStartup
    {
        private readonly IContext _context;

        public DbPersistChanges(IContext context)
        {
            _context = context;
        }

        public void Initialize(IPipelines pipelines, Nancy.NancyContext context)
        {
            pipelines.AfterRequest += (ctx) => _context.Save();
        }
    }
}