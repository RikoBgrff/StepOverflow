using StepOverflow.Entities;
using System;
using System.Collections.Generic;

namespace StepOverflow.Areas.Main.Models
{
	public class UsersViewModel
	{
		public string Id { get; set; }

		public string Username { get; set; }
		public DateTime? JoinDate { get; set; }
		public string? Location { get; set; }
		public string? ProfilePicture { get; set; }
		public int? ReputationCount { get; set; }
		public string? Biography { get; set; }
		public string Github { get; set; }

	}
}
