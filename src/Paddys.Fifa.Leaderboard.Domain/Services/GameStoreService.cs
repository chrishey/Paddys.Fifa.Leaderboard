using System;
using Microsoft.Azure.Documents;
using Paddys.Fifa.Leaderboard.Data.Model;
using Paddys.Fifa.Leaderboard.Interfaces.Data;
using Paddys.Fifa.Leaderboard.Interfaces.Games;

namespace Paddys.Fifa.Leaderboard.Domain.Services
{
	public class GameStoreService : IGameStoreService
	{
		private readonly IContext _context;

		public GameStoreService(IContext context)
		{
			_context = context;
		}

        public async void Add(Game game)
        {
            var collection = new DocumentCollection { Id = "Games" };
            collection = await _context.Client.CreateDocumentCollectionAsync(_context.Database.CollectionsLink, collection);
            await _context.Client.CreateDocumentAsync(collection.DocumentsLink, game);
        }

        /// <summary>
        /// There is a end of pipeline event set up to persist changes to the context <see cref="C:\Users\Chris Hey\Source\Repos\Paddys.Fifa.Leaderboard\src\Paddys.Fifa.Leaderboard.Web\Startup\DbPersistChanges.cs"/>
        /// </summary>
        public void Save()
        {
            throw new NotImplementedException();
        }
	}
}