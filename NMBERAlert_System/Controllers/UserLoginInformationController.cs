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
	public class UserLoginInformationController : ODataController
	{
		public UserLoginInformationController(NMBER_SystemMainDbContext db)
		{
			this.db = db;
		}

		readonly NMBER_SystemMainDbContext db;

		[EnableQuery(MaxTop = 100)]
		public IQueryable<UserLoginInformation> Get()
		{
			return db.UserLoginInformation;
		}

		[EnableQuery]
		public SingleResult<UserLoginInformation> Get([FromODataUri] int key)
		{
			IQueryable<UserLoginInformation> result = db.UserLoginInformation.Where(p => p.Id == key);
			return SingleResult.Create(result);
		}
		public async Task<IActionResult> Post([FromBody] UserLoginInformation inserted)
		{
			try
			{
				if (!ModelState.IsValid) return BadRequest();

				db.UserLoginInformation.Add(inserted);
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

		public async Task<IActionResult> Put(int key, [FromBody] UserLoginInformation update)
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
			return db.UserLoginInformation.Any(p => p.Id == key);
		}
	}
}
