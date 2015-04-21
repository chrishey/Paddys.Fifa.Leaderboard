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
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
