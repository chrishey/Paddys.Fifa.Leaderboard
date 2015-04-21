using System;
using Paddys.Fifa.Leaderboard.Domain.Services;
using Paddys.Fifa.Leaderboard.Interfaces.Players;
using Paddys.Fifa.Leaderboard.Tests.Fixtures;
using Xunit;

namespace Paddys.Fifa.Leaderboard.Tests
{
    public class PlayerTests : IClassFixture<ContextFixture>
    {
        private readonly ContextFixture _contextFixture;
        private readonly Random _random = new Random();
        private readonly IPlayerStoreService _playerStoreService;

        public PlayerTests(ContextFixture contextFixture)
        {
            _contextFixture = contextFixture;
            _playerStoreService = new PlayerStoreService(_contextFixture);
        }

        [Fact]
        public void AddPlayer()
        {
            // Given
            var player = _contextFixture.Players[_random.Next(0, _contextFixture.Players.Count)];

            // When
            _playerStoreService.Add(player);

            // Then
            Assert.NotEmpty(_contextFixture.Players);
            Assert.Contains(_contextFixture.Players, p=>p.Id == player.Id && p.FirstName == player.FirstName && p.Surname == player.Surname);
        }
    }
}
