using System;
using System.Collections.Generic;
using Paddys.Fifa.Leaderboard.Data.Model;
using Paddys.Fifa.Leaderboard.Interfaces.Data;

namespace Paddys.Fifa.Leaderboard.Tests.Fixtures
{
    public class ContextFixture : IDisposable, IContext
    {
        public IList<Game> Games { get; set; }
        public IList<Player> Players { get; set; } 

        public ContextFixture()
        {
            Games = new List<Game>();
            Players = GeneratePlayers();

        }

        public void Dispose()
        {
            Games = null;
            Players = null;
        }

        private IList<Player> GeneratePlayers()
        {
            return new List<Player>
            {
                new Player {Id = Guid.NewGuid(), FirstName = "Chris", Surname = "Hey", Coefficient = 0.01},
                new Player {Id = Guid.NewGuid(), FirstName = "Dave", Surname = "Saunders", Coefficient = 0.1},
                new Player {Id = Guid.NewGuid(), FirstName = "Steve", Surname = "Robbins", Coefficient = 0.5},
                new Player {Id = Guid.NewGuid(), FirstName = "Paddy", Surname = "Halle", Coefficient = 1}
            };
        }
    }
}
