using System;
using Paddys.Fifa.Leaderboard.Data.Model;
using Paddys.Fifa.Leaderboard.Interfaces.Games;
using Paddys.Fifa.Leaderboard.Tests.Fixtures;
using Paddys.Fifa.Leaderboard.Tests.Services;
using Xunit;

namespace Paddys.Fifa.Leaderboard.Tests
{
    public class GameTests : IClassFixture<ContextFixture>
    {
        private readonly ContextFixture _contextFixture;
        private readonly Random _random = new Random();
        private readonly IGameStoreService _gameStoreService;

        public GameTests(ContextFixture contextFixture)
        {
            _contextFixture = contextFixture;
            _gameStoreService = new TestGameStoreService(contextFixture);
        }

        [Fact]
        public void SaveGame()
        {
            // Given
            var game = new Game
            {
                Player1 = _contextFixture.Players[_random.Next(0, _contextFixture.Players.Count)],
                Player2 = _contextFixture.Players[_random.Next(0, _contextFixture.Players.Count)],
                Player1Score = _random.Next(0, 3),
                Player2Score = _random.Next(0, 3)
            };

            // When
            _gameStoreService.Add(game);
            _gameStoreService.Save();

            // Then
            Assert.NotEmpty(_contextFixture.Games);
            Assert.Contains(_contextFixture.Games, g=>g.Player1 == game.Player1 && g.Player2 == game.Player2 && g.Player1Score == game.Player1Score && g.Player2Score == game.Player2Score);
        }
    }
}
