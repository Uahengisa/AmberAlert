using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class AuthUserInformation
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid UserGuid { get; set; }
		public string Username { get; set; }
		public string LoginKey { get; set; }
		public string DisplayName { get; set; }

	}
}


/*
 
 
 START
1. DECLARE VARIABLE NAME

2. PRINT("ENTER NAME: ")

3. SAVE NAME

4. PRINT $NAME

END
 
 
 
 */






