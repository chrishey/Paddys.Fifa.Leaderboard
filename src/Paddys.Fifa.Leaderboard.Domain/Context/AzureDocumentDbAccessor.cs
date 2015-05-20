using System.Collections.Generic;
using Microsoft.Azure.Documents;

namespace Paddys.Fifa.Leaderboard.Domain.Context
{
	public static class AzureDocumentDbAccessor<T> where T : class 
	{
		public static IList<T> DocumentDbCollection(string documentType, Database database)
		{
			var documents = new List<T>();



			return documents;
		}
	}
}
