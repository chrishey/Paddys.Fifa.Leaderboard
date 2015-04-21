using System;
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
		
		[Range(1, 10)]
		public int		PlayerLevel	{ get; set; }
	}
}