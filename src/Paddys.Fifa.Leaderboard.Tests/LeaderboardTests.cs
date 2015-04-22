using System;
using System.Linq;
using Paddys.Fifa.Leaderboard.Domain.Services;
using Paddys.Fifa.Leaderboard.Interfaces.Leaderboard;
using Paddys.Fifa.Leaderboard.Tests.Fixtures;
using Xunit;

namespace Paddys.Fifa.Leaderboard.Tests
{
    public class LeaderboardTests : IClassFixture<ContextFixture>
    {
        private readonly ContextFixture _contextFixture;
        private readonly ILeaderboardReadService _leaderboardReadService;
        private Random _random = new Random();

        public LeaderboardTests(ContextFixture contextFixture)
        {
            _contextFixture = contextFixture;
            _leaderboardReadService = new LeaderboardReadService(_contextFixture);
        }

        [Fact]
        public void DisplayLeaderboard()
        {
            // Given
            _contextFixture.Players.ToList().ForEach(p=>p.Score = _random.Next(0, 10));

            // When
            var leaderboard = _leaderboardReadService.GetLeaderboard();

            // Then
            Assert.NotNull(leaderboard);
        }
    }
}
