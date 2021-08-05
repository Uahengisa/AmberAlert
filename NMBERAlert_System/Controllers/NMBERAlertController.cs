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
	public class NMBERAlertController : ODataController
	{
		public NMBERAlertController(NMBER_SystemMainDbContext db)
		{
			this.db = db;
		}

		readonly NMBER_SystemMainDbContext db;

		[EnableQuery(MaxTop = 100)]
		public IQueryable<NMBERAlert> Get()
		{
			return db.NMBERAlert;
		}

		[EnableQuery]
		public SingleResult<NMBERAlert> Get([FromODataUri] Guid key)
		{
			IQueryable<NMBERAlert> result = db.NMBERAlert.Where(p => p.NMBERAlertGuid == key);
			return SingleResult.Create(result);
		}
		public async Task<IActionResult> Post([FromBody] NMBERAlert inserted)
		{
			try
			{
				if (!ModelState.IsValid) return BadRequest();

				db.NMBERAlert.Add(inserted);
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

		public async Task<IActionResult> Put(Guid key, [FromBody] NMBERAlert update)
		{
			if (!ModelState.IsValid) return BadRequest();
			if (key != update.NMBERAlertGuid) return BadRequest("Key mismatch");

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
			return db.NMBERAlert.Any(p => p.NMBERAlertGuid == key);
		}
	}
}
