using Nancy;
using Paddys.Fifa.Leaderboard.Interfaces.Leaderboard;

namespace Paddys.Fifa.Leaderboard.Modules
{
    public class IndexModule : NancyModule
    {
        private readonly ILeaderboardReadService _leaderboardReadService;

        public IndexModule(ILeaderboardReadService leaderboardReadService)
        {
            _leaderboardReadService = leaderboardReadService;
            Get["/"] = _ => View["index"];
            Get["/leaderboard"] = _ => GetLeaderboard();
        }

        private dynamic GetLeaderboard()
        {
            var leaderboard = _leaderboardReadService.GetLeaderboard();

            return Response.AsJson(leaderboard);
        }
    }
}