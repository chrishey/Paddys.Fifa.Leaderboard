using System.Collections.Generic;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Paddys.Fifa.Leaderboard.Data.Model;

namespace Paddys.Fifa.Leaderboard.Interfaces.Data
{
    public interface IContext
    {
        Database Database { get; }
        DocumentClient Client { get; }
        IList<Game> Games { get; set; }
        IList<Player> Players { get; set; }

        void Save();
    }
}
