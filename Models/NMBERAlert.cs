using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class NMBERAlert
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid NMBERAlertGuid { get; set; }
		public string ChildFirstName { get; set; }
		public string ChildLastName { get; set; }
		public Guid UserGuid { get; set; }
		public string ChildDescription { get; set; }
		public string ChildLastSeenLocation { get; set; }
		public DateTime ChildAbductionDate { get; set; }
		public string ChildGender { get; set; }
		public string ChildRace { get; set; }
		public double ChildHeight { get; set; }
		public string AbductionNarrative { get; set; }

	}
}
