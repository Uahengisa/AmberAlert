using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class UserInformation
	{
		[Key]
		public Guid UserGuid { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string IdNumber { get; set; }
		public string MainContactNumber { get; set; }
		public string SecondaryContactNumber { get; set; }
		public string PrimaryAddress { get; set; }

	}
}
