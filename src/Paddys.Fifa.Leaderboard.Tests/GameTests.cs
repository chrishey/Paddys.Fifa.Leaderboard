using Paddys.Fifa.Leaderboard.Data.Model;
using Paddys.Fifa.Leaderboard.Tests.Fixtures;
using Xunit;

namespace Paddys.Fifa.Leaderboard.Tests
{
    public class GameTests : IClassFixture<ContextFixture>
    {
        private readonly ContextFixture _contextFixture;

        public GameTests(ContextFixture contextFixture)
        {
            _contextFixture = contextFixture;
        }

        [Fact]
        public void SaveGame()
        {
            // Given
            var game = new Game {};

            // When

            // Then
        }
    }
}
