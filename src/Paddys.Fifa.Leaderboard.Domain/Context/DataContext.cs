using System;
using System.Collections.Generic;
using Paddys.Fifa.Leaderboard.Data.Model;
using Paddys.Fifa.Leaderboard.Interfaces.Data;

namespace Paddys.Fifa.Leaderboard.Domain.Context
{
    public class DataContext : IContext
    {
        public IList<Game> Games
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IList<Player> Players
        {
            get
            {
                return new List<Player>
                {
                    new Player {Id = Guid.NewGuid(), FirstName = "Chris", Surname = "Hey", Coefficient = 0.01, Score = 10},
                    new Player {Id = Guid.NewGuid(), FirstName = "Dave", Surname = "Saunders", Coefficient = 0.1, Score = 5},
                    new Player {Id = Guid.NewGuid(), FirstName = "Steve", Surname = "Robbins", Coefficient = 0.5, Score = 2},
                    new Player {Id = Guid.NewGuid(), FirstName = "Paddy", Surname = "Halle", Coefficient = 1, Score = 8}
                };
            }
            set { throw new NotImplementedException(); }
        }
    }
}
