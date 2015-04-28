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

        [Fact]
        public void DisplayLeaderboard_CorrectOrder()
        {
            // Given
            _contextFixture.Players[1].Score = 10;
            _contextFixture.Players[3].Score = 8;
            _contextFixture.Players[2].Score = 6;
            _contextFixture.Players[0].Score = 4;

            // When
            var leaderboard = _leaderboardReadService.GetLeaderboard();

            // Then
            var result = leaderboard.ToList();
            Assert.Equal(result.Count, 4);
            Assert.True(result[0].Id == _contextFixture.Players[1].Id);
            Assert.True(result[1].Id == _contextFixture.Players[3].Id);
            Assert.True(result[2].Id == _contextFixture.Players[2].Id);
            Assert.True(result[3].Id == _contextFixture.Players[0].Id);
        }
    }
}
