using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using PDM_API.Models;
using PDM_API.Providers;

namespace PDM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Pdm.Member")]
    public class WellProdDayController : ControllerBase
    {
        private PDMContext _db;
        private IUserProvider _userProvider;
        readonly ILogger _logger;

        public WellProdDayController(PDMContext context, IUserProvider userProvider, ILoggerFactory loggerFactory)
        {
            _db = context;
            _userProvider = userProvider;
            _logger = loggerFactory.CreateLogger("WellProdDayController");
        }

        /// <summary>
        /// WellProdDay
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (Default 1000)</param>
        /// <param name="START_PROD_DAY">Greater then or equal to. Example: 2019-01-01</param>
        /// <param name="END_PROD_DAY">Lesser then or equal to. Example: 2019-01-01</param>
        /// <param name="WELL_ID_EC">Equal to</param>
        /// <param name="DBSOURCE_ID">Equal to</param>
        /// <param name="GOV_FCTY_NAME">Equal to</param>
        [HttpGet]
        [ProducesResponseType(typeof(WellProdDay), 200)]
        public async Task<IActionResult> GetWellProdDay(int? skip, int? top, DateTime? START_PROD_DAY, DateTime? END_PROD_DAY, string WELL_ID_EC, string DBSOURCE_ID, string GOV_FCTY_NAME)
        {
            int s = (skip == null) ? 0 : skip.GetValueOrDefault();
            int t = (top == null) ? 1000 : top.GetValueOrDefault();

            if (s < 0)
                return BadRequest("Skip can't be a negative number");

            if (t < 1)
                return BadRequest("Top can't be less then 1");

            /* This section builds the filter that is used in the stored procedure
             */
            List<string> where = new List<string>();
            if (START_PROD_DAY != null)
            {
                where.Add("t.PROD_DAY >= '" + START_PROD_DAY.GetValueOrDefault().ToString("yyyy-MM-dd") + "'");
            }
            if (END_PROD_DAY != null)
            {
                where.Add("t.PROD_DAY <= '" + END_PROD_DAY.GetValueOrDefault().ToString("yyyy-MM-dd") + "'");
            }
            if (WELL_ID_EC != null)
            {
                where.Add("t.WELL_ID_EC = '" + WELL_ID_EC + "'");
            }
            if (DBSOURCE_ID != null)
            {
                where.Add("t.DBSOURCE_ID = '" + DBSOURCE_ID + "'");
            }
            if (GOV_FCTY_NAME != null)
            {
                where.Add("t.GOV_FCTY_NAME = '" + GOV_FCTY_NAME + "'");
            }
            // If this fails the user isn't signed in (Dirty fix, TODO: Clean fix below)
            var paramUserName = new SqlParameter();
            try
            {
                paramUserName = new SqlParameter("@userName", _userProvider.GetUserName());
            }
            catch
            {
                return Unauthorized();
            }
            var paramTop = new SqlParameter("@top", t.ToString());
            var paramSkip = new SqlParameter("@skip", s.ToString());
            var paramFilter = new SqlParameter("@filter", where.Count > 0 ? (object)string.Join(" AND ", where) : DBNull.Value);
            var paramSource = new SqlParameter("@sourceView", "[PDM].[WELL_PROD_DAY]");
            // t = source table/view, w = WELL_MASTER
            var paramJoinColumn = new SqlParameter("@joinColumn", "W.GOV_FCTY_NAME = t.GOV_FCTY_NAME");

            try
            {
                var response = _db.WellProdDay.FromSql("EXEC [PDM].[P_GetDataWithRowLevelSecurity] @userName, @top, @skip, @filter, @sourceView, @joinColumn", paramUserName, paramTop, paramSkip, paramFilter, paramSource, paramJoinColumn);

                return Ok(await response.ToArrayAsync());
            }
            catch (Exception e)
            {
                _logger.LogError("Something went wrong in WellProdDayController: " + e.Message);
                throw;
            }
        }
    }
}