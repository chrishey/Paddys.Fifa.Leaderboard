using System;
using System.Collections.Generic;
using Paddys.Fifa.Leaderboard.Data.Model;

namespace Paddys.Fifa.Leaderboard.Tests.Fixtures
{
    public class ContextFixture : IDisposable
    {
        public IList<Game> Games { get; private set; }
        public IList<Game> Players { get; private set; } 

        public ContextFixture()
        {
            Games = new List<Game>();
            Players = GeneratePlayers();

        }

        public void Dispose()
        {
            Games = null;
        }

        private IList<Game> GeneratePlayers()
        {
            throw new NotImplementedException();
        }
    }
}
