using Nancy;
using Paddys.Fifa.Leaderboard.Interfaces.Leaderboard;
using Paddys.Fifa.Leaderboard.Interfaces.Players;

namespace Paddys.Fifa.Leaderboard.Modules
{
    public class IndexModule : NancyModule
    {
        private readonly ILeaderboardReadService _leaderboardReadService;
	    private readonly IPlayerReadService _playerService;

	    public IndexModule(ILeaderboardReadService leaderboardReadService, IPlayerReadService playerService)
        {
            _leaderboardReadService = leaderboardReadService;
		    _playerService = playerService;
		    Get["/"] = _ => View["index"];
            Get["/leaderboard"] = _ => GetLeaderboard();
	        Get["/players"] = _ => GetAllPlayers();
        }

	    private dynamic GetAllPlayers()
	    {
		    var players = _playerService.GetAllPlayers();

		    return Response.AsJson(players);
	    }

	    private dynamic GetLeaderboard()
        {
            var leaderboard = _leaderboardReadService.GetLeaderboard();

            return Response.AsJson(leaderboard);
        }
    }
}