using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Controllers
{
	public class UserInformationController : ODataController
	{
		public UserInformationController(NMBER_SystemMainDbContext db)
		{
			this.db = db;
		}

		readonly NMBER_SystemMainDbContext db;

		[EnableQuery(MaxTop = 100)]
		public IQueryable<UserInformation> Get()
		{
			return db.UserInformation;
		}

		[EnableQuery]
		public SingleResult<UserInformation> Get([FromODataUri] Guid key)
		{
			IQueryable<UserInformation> result = db.UserInformation.Where(p => p.UserGuid == key);
			return SingleResult.Create(result);
		}
		public async Task<IActionResult> Post([FromBody] UserInformation inserted)
		{
			try
			{
				if (!ModelState.IsValid) return BadRequest();

				db.UserInformation.Add(inserted);
				await db.SaveChangesAsync();

				return Created(inserted);
			}
			catch (DbUpdateException ex)
			{
				return BadRequest(ex);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<IActionResult> Put(Guid key, [FromBody] UserInformation update)
		{
			if (!ModelState.IsValid) return BadRequest();
			if (key != update.UserGuid) return BadRequest("Key mismatch");

			db.Entry(update).State = EntityState.Modified;
			try
			{
				await db.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!Exists(key)) return BadRequest("Does Not exist [ ! ]");
				else return BadRequest("Already Updated [ ! ]");
			}
			catch (Exception)
			{
				throw;
			}

			return Updated(update);
		}

		private bool Exists(Guid key)
		{
			return db.UserInformation.Any(p => p.UserGuid == key);
		}
	}
}
