using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Paddys.Fifa.Leaderboard.ViewModels
{
	public class PlayerDetails
	{
		[Required]
		public string	FirstName	{ get; set; }
		
		[Required]
		public string	Surname		{ get; set; }
		
		[Required, Range(1, 10)]
		public int		Level		{ get; set; }
	}
}