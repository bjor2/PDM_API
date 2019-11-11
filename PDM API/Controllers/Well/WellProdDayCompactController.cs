﻿using System;
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
    public class WellProdDayCompactController : ControllerBase
    {
        readonly ILogger _logger;
        private PDMContext _db;

        public WellProdDayCompactController(ILogger<WellProdDayCompactController> logger, PDMContext context)
        {
            _logger = logger;
            _db = context;
        }

        /// <summary>
        /// WellProdDayCompact
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (Default 1000)</param>
        /// <param name="columns">Columns to return. Example: Column1,Column2</param>
        /// <param name="START_PROD_DAY">Greater then or equal to. Example: 2019-01-01</param>
        /// <param name="END_PROD_DAY">Lesser then or equal to. Example: 2019-01-01</param>
        /// <param name="WELL_ID_EC">Equal to</param>
        /// <param name="DBSOURCE_ID">Equal to</param>
        /// <param name="WELL_UWI">Equal to</param>
        /// <param name="GOV_FCTY_NAME">Equal to</param>
        [HttpGet]
        [ProducesResponseType(typeof(WellProdDayCompact), 200)]
        public async Task<IActionResult> GetWellProdDayCompact(int? skip, int? top, string columns, DateTime? START_PROD_DAY, DateTime? END_PROD_DAY, string WELL_ID_EC, string DBSOURCE_ID, string WELL_UWI, string GOV_FCTY_NAME)
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
                WellProdDay obj = new WellProdDay();
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
                var result = await _db.WellProdDay
                    .Where(e =>
                        (e.PROD_DAY >= START_PROD_DAY || START_PROD_DAY == null)
                        && (e.PROD_DAY <= END_PROD_DAY || END_PROD_DAY == null)
                        && (e.WELL_ID_EC == WELL_ID_EC || WELL_ID_EC == null)
                        && (e.DBSOURCE_ID == DBSOURCE_ID || DBSOURCE_ID == null)
                        && (WELL_UWI == null || e.WELL_UWI == WELL_UWI)
                        && (GOV_FCTY_NAME == null || e.GOV_FCTY_NAME == WELL_UWI)                        
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
                _logger.LogError($"Something went wrong in WellProdDayCompactController: {e.Message}. Stacktrace: {e.StackTrace}");
                return StatusCode(500);
            }
        }
    }
}