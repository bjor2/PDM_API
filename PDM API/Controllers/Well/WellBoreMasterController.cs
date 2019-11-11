using System;
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
    public class WellBoreMasterController : ControllerBase
    {
        private PDMContext _db;

        public WellBoreMasterController(PDMContext context)
        {
            _db = context;
        }

        /// <summary>
        /// WellBoreMaster
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (default 1000)</param>
        /// <param name="columns">Columns to return. Example: Column1,Column2</param>
        /// <param name="WB_V_START_DATE">Greater then or equal to. Example: 2019-01-01T00:00:00</param>
        /// <param name="DBSOURCE_ID">Equal to</param>
        /// <param name="WB_CODE">Equal to</param>
        [HttpGet]
        [ProducesResponseType(typeof(WellBoreMaster), 200)]
        public async Task<IActionResult> GetWellBoreMaster(int? skip, int? top, string columns, DateTime? WB_V_START_DATE, string DBSOURCE_ID, string WB_CODE)
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
            WellBoreMaster obj = new WellBoreMaster();
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
            var result = _db.WellBoreMaster
                .Where(e =>
                    (e.WB_V_START_DATE >= WB_V_START_DATE || WB_V_START_DATE == null)
                    && (e.DBSOURCE_ID == DBSOURCE_ID || DBSOURCE_ID == null)
                    && (WB_CODE == "" || WB_CODE == null || e.WB_CODE == WB_CODE)
                )
                .Skip(s)
                .Take(t)
				.Select("new(" + columns + ")");
 
            return Ok(await result.ToDynamicListAsync());
        }
    }
}