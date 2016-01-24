using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using Paddys.Fifa.Leaderboard.Data.Model;
using Paddys.Fifa.Leaderboard.Interfaces.Data;

namespace Paddys.Fifa.Leaderboard.Domain.Context
{
    public class DataContext : IContext
    {
	    public Database Database { get; private set; }
        public DocumentClient Client { get; private set; }

	    public DataContext()
	    {
		    CreateClient();
		    RetrieveOrCreateDatabase().Wait();
	    }

	    private async Task RetrieveOrCreateDatabase()
	    {
	        Database =
	            Client.CreateDatabaseQuery().AsEnumerable()
	                .FirstOrDefault(db => db.Id == ConfigurationManager.AppSettings["AzureDocumentDbName"]) ??
	            await Client.CreateDatabaseAsync(new Database {Id = ConfigurationManager.AppSettings["AzureDocumentDbName"]});
	    }

	    private void CreateClient()
	    {
		    Client =
			    new DocumentClient(new Uri(ConfigurationManager.ConnectionStrings["leaderboardDocumentDB"].ConnectionString),
				    ConfigurationManager.AppSettings["leaderboardAPIKey"]);
	    }

        public IList<Game> Games
        {
            get
            {
                var collection = AzureDocumentDbAccessor.DocumentDbCollection("Games", Database, Client).Result;
                var documents =
                    Client.CreateDocumentQuery<Game>("dbs/" + Database.Id + "/colls/" + collection.Id).Select(d => d);
                return documents.ToArray();

                //return DocumentDbConverter<Game>.DocumentsFromCollection(collection);
            }
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

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
