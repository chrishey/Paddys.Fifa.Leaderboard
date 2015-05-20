using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using Paddys.Fifa.Leaderboard.Data.Model;
using Paddys.Fifa.Leaderboard.Interfaces.Data;

namespace Paddys.Fifa.Leaderboard.Domain.Context
{
    public class DataContext : IContext
    {
	    private Database _database;
	    private DocumentClient _client;

	    public DataContext()
	    {
		    CreateClient();
		    RetrieveOrCreateDatabase();
	    }

	    private async void RetrieveOrCreateDatabase()
	    {
		    _database =
			    _client.CreateDatabaseQuery().FirstOrDefault(db => db.Id == ConfigurationManager.AppSettings["AzureDocumentDbName"]) ??
			    await _client.CreateDatabaseAsync(new Database { Id = ConfigurationManager.AppSettings["AzureDocumentDbName"] });
	    }

	    private void CreateClient()
	    {
		    _client =
			    new DocumentClient(new Uri(ConfigurationManager.ConnectionStrings["leaderboardDocumentDB"].ConnectionString),
				    ConfigurationManager.AppSettings["leaderboardAPIKey"]);
	    }

	    public IList<Game> Games
        {
            get { return AzureDocumentDbAccessor<Game>.DocumentDbCollection("Games", _database, _client).Result; }
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
