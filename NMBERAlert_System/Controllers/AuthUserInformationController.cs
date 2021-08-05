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

namespace NMBERAlert_System.Controllers
{
	public class AuthUserInformationController : ODataController
	{
		public AuthUserInformationController(NMBER_SystemMainDbContext db)
		{
			this.db = db;
		}

		readonly NMBER_SystemMainDbContext db;

		[EnableQuery(MaxTop = 100)]
		public IQueryable<AuthUserInformation> Get()
		{
			return db.AuthUserInformation;
		}

		[EnableQuery]
		public SingleResult<AuthUserInformation> Get([FromODataUri] int key)
		{
			IQueryable<AuthUserInformation> result = db.AuthUserInformation.Where(p => p.Id == key);
			return SingleResult.Create(result);
		}
		public async Task<IActionResult> Post([FromBody] AuthUserInformation inserted)
		{
			try
			{
				if (!ModelState.IsValid) return BadRequest();

				db.AuthUserInformation.Add(inserted);
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

		public async Task<IActionResult> Put(int key, [FromBody] AuthUserInformation update)
		{
			if (!ModelState.IsValid) return BadRequest();
			if (key != update.Id) return BadRequest("Key mismatch");

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

		private bool Exists(int key)
		{
			return db.AuthUserInformation.Any(p => p.Id == key);
		}
	}
}
