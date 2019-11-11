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
    public class FlowlineMasterController : ControllerBase
    {
        private PDMContext _db;

        public FlowlineMasterController(PDMContext context)
        {
            _db = context;
        }

        /// <summary>
        /// FlowlineMaster
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (default 1000)</param>
        /// <param name="columns">Columns to return. Example: Column1,Column2</param>
        /// <param name="FCTY_CODE">Equal to</param>
        /// <param name="FLW_CODE">Equal to</param>
        /// <param name="FLW_V_START_DATE">Greater then or equal to. Example: 2019-01-01T00:00:00</param>
        /// <param name="DBSOURCE_ID">Equal to</param>
        [HttpGet]
        [ProducesResponseType(typeof(FlowlineMaster), 200)]
        public async Task<IActionResult> GetFlowlineMaster(int? skip, int? top, string columns, string FCTY_CODE, string FLW_CODE, DateTime? FLW_V_START_DATE, string DBSOURCE_ID)
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
            FlowlineMaster obj = new FlowlineMaster();
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
            var result = _db.FlowlineMaster
                .Where(e =>
                    (e.FCTY_CODE == FCTY_CODE || FCTY_CODE == null)
                    && (e.FLW_CODE == FLW_CODE || FLW_CODE == null)
                    && (e.FLW_V_START_DATE >= FLW_V_START_DATE || FLW_V_START_DATE == null)
                    && (e.DBSOURCE_ID == DBSOURCE_ID || DBSOURCE_ID == null)
                )
                .Skip(s)
                .Take(t)
				.Select("new(" + columns + ")");
            
            return Ok(await result.ToDynamicListAsync());
        }
    }
}