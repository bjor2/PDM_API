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
    public class StreamPcAllocDayController : ControllerBase
    {
        private PDMContext _db;

        public StreamPcAllocDayController(PDMContext context)
        {
            _db = context;
        }

        /// <summary>
        /// StreamPcAllocDay
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (default 1000)</param>
        /// <param name="columns">Columns to return. Example: Column1,Column2</param>
        /// <param name="START_PROD_DAY">Greater then or equal to. Example: 2019-01-01</param>
        /// <param name="END_PROD_DAY">Lesser then or equal to. Example: 2019-01-01</param>
        /// <param name="PROFIT_CENTRE">Equal to</param>
        /// <param name="STREAM_ID_EC">Equal to</param>
        /// <param name="DBDATA_CLASS">Equal to</param>
        /// <param name="DBSOURCE_ID">Equal to</param>
        [HttpGet]
        [ProducesResponseType(typeof(StreamPcAllocDay), 200)]
        public async Task<IActionResult> GetStreamPcAllocDay(int? skip, int? top, string columns, DateTime? START_PROD_DAY, DateTime? END_PROD_DAY, string PROFIT_CENTRE, string STREAM_ID_EC, string DBDATA_CLASS, string DBSOURCE_ID)
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
            StreamPcAllocDay obj = new StreamPcAllocDay();
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
            var result = _db.StreamPcAllocDay
                .Where(e =>
                    (e.PROD_DAY >= START_PROD_DAY || START_PROD_DAY == null)
                    && (e.PROD_DAY <= END_PROD_DAY || END_PROD_DAY == null)
                    && (e.PROFIT_CENTRE == PROFIT_CENTRE || PROFIT_CENTRE == null)
                    && (e.STREAM_ID_EC == STREAM_ID_EC || STREAM_ID_EC == null)
                    && (e.DBDATA_CLASS == DBDATA_CLASS || DBDATA_CLASS == null)
                    && (e.DBSOURCE_ID == DBSOURCE_ID || DBSOURCE_ID == null)
                )
                .Skip(s)
                .Take(t)
				.Select("new(" + columns + ")");
 
            return Ok(await result.ToDynamicListAsync());
        }
    }
}