using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PDM_API.Models;

namespace PDM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Pdm.Member")]
    [ApiExplorerSettings(GroupName = "internal")]
    public class FacilityMasterController : ControllerBase
    {
        private PDMContext _db;

        public FacilityMasterController(PDMContext context)
        {
            _db = context;
        }

        /// <summary>
        /// FacilityMaster
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (default 1000)</param>
        /// <param name="columns">Columns to return. Example: Column1,Column2</param>
        /// <param name="FCTY_CODE">Equal to</param>
        /// <param name="FCTY_NAME">Equal to</param>
        /// <param name="FCTY_V_START_DATE">Greater then or equal to. Example: 2019-01-01T00:00:00</param>
        [HttpGet]
        [ProducesResponseType(typeof(FacilityMaster), 200)]
        public async Task<IActionResult> GetFacilityMaster(int? skip, int? top, string columns, string FCTY_CODE, string FCTY_NAME, DateTime? FCTY_V_START_DATE)
        {
            int s = (skip == null) ? 0 : skip.GetValueOrDefault();
            int t = (top == null) ? 1000 : top.GetValueOrDefault();

            if (s < 0)
                return BadRequest("Skip can't be a negative number");
            if (t < 1)
                return BadRequest("Top can't be less then 1");

            if(columns != null)
                columns = columns.Replace(" ", "");

            /* This section is used to check the existence of columns suplied in the request,
             * and in the event of no columns being supplied finds a list of each column of the given model.
             */
            FacilityMaster obj = new FacilityMaster();
			var cols = obj.GetType().GetProperties().Select(e => e.Name.ToUpper()).ToArray();
			if (columns == null)
			{
				columns = string.Join(",", cols);
			}
			else
			{
				string[] colSplit = columns.Split(',');
				foreach (string col in colSplit)
				{
					if (!cols.Contains(col.Trim().ToUpper()))
					{
						return BadRequest(col + " is not a valid column");
					}
				}
			}

            /* This section takes care of the db request.
             * Here Linq.Dynamic.Core is used to dynamically select specific columns.
             */
            var result = _db.FacilityMaster
                .Where(e =>
                    (e.FCTY_CODE == FCTY_CODE || FCTY_CODE == null)
                    && (e.FCTY_NAME == FCTY_NAME || FCTY_NAME == null)
                    && (e.FCTY_V_START_DATE >= FCTY_V_START_DATE || FCTY_V_START_DATE == null)
                )
                .Skip(s)
                .Take(t)
				.Select("new(" + columns + ")");
            return Ok(await result.ToDynamicListAsync());
        }
    }
}