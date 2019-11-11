using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using PDM_API.Models;

namespace PDM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Pdm.Member")]
    [ApiExplorerSettings(GroupName = "internal")]
    public class WellBoreProdDayCompactController : ControllerBase
    {
        readonly ILogger _logger;
        private PDMContext _db;

        public WellBoreProdDayCompactController(ILogger<WellBoreProdDayCompactController> logger, PDMContext context)
        {
            _logger = logger;
            _db = context;
        }

        /// <summary>
        /// WellBoreProdDayCompact
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (Default 1000)</param>
        /// <param name="columns">Columns to return. Example: Column1,Column2</param>
        /// <param name="START_PROD_DAY">Greater then or equal to. Example: 2019-01-01</param>
        /// <param name="END_PROD_DAY">Lesser then or equal to. Example: 2019-01-01</param>
        /// <param name="PERF_CODE">Equal to</param>
        /// <param name="WB_V_START_DATE">Greater then or equal to. Example: 2019-01-01T00:00:00</param>
        /// <param name="DBSOURCE_ID">Equal to</param>
        /// <param name="WELL_BORE_CODE">Equal to</param>
        /// <param name="GOV_FCTY_NAME">Equal to</param>
        [HttpGet]
        [ProducesResponseType(typeof(WellBoreProdDayCompact), 200)]
        public async Task<IActionResult> GetWellBoreProdDayCompact(int? skip, int? top, string columns, DateTime? START_PROD_DAY, DateTime? END_PROD_DAY, string PERF_CODE, DateTime? WB_V_START_DATE, string DBSOURCE_ID, string WELL_BORE_CODE, string GOV_FCTY_NAME)
        {
            try
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
                WellBoreProdDay obj = new WellBoreProdDay();
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
                var result = await _db.WellBoreProdDay
                    .Where(e =>
                        (e.PROD_DAY >= START_PROD_DAY || START_PROD_DAY == null)
                        && (e.PROD_DAY <= END_PROD_DAY || END_PROD_DAY == null)
                        && (e.PERF_CODE == PERF_CODE || PERF_CODE == null)
                        && (e.WB_V_START_DATE >= WB_V_START_DATE || WB_V_START_DATE == null)
                        && (e.DBSOURCE_ID == DBSOURCE_ID || DBSOURCE_ID == null)
                        && (e.WELL_BORE_CODE == WELL_BORE_CODE || WELL_BORE_CODE == null)
                        && (e.GOV_FCTY_NAME == GOV_FCTY_NAME || GOV_FCTY_NAME == null)                        
                    )
                    .Skip(s)
                    .Take(t)
                    .Select("new(" + columns + ")").ToDynamicListAsync();

                /* This section transforms the result of the db request from a list of objects
                 * into a single object with value lists, making the column names only appear once.
                 */
                var props = columns.Split(',');
                var jsonResult = new JObject();
                
                foreach (string p in props)
                {
                    jsonResult[p] = new JArray(result.Select(e => e.GetType().GetProperty(p).GetValue(e, null)).ToArray());
                }

                return Ok(jsonResult);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong in WellBoreProdDayCompactController: {e.Message}. Stacktrace: {e.StackTrace}");
                return StatusCode(500);
            }
        }
    }
}