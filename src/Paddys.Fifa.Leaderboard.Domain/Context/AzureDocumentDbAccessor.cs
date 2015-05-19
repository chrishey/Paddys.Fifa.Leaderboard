using System.Collections.Generic;

namespace Paddys.Fifa.Leaderboard.Domain.Context
{
	public static class AzureDocumentDbAccessor<T> where T : class 
	{
		public static IList<T> DocumentDbCollection(string documentType)
		{
			var documents = new List<T>();

			return documents;
		}
	}
}
