using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PDM_API.Models;
using PDM_API.Providers;

namespace PDM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Pdm.Member")]
    public class FlwProdDayController : ControllerBase
    {
        private PDMContext _db;
        private IUserProvider _userProvider;
        readonly ILogger _logger;

        public FlwProdDayController(PDMContext context, IUserProvider userProvider, ILoggerFactory loggerFactory)
        {
            _db = context;
            _userProvider = userProvider;
            _logger = loggerFactory.CreateLogger("FlwProdDayController");
        }

        /// <summary>
        /// FlwProdDay
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (default 1000)</param>
        /// <param name="START_PROD_DAY">Greater then or equal to. Example: 2019-01-01</param>
        /// <param name="END_PROD_DAY">Lesser then or equal to. Example: 2019-01-01</param>
        /// <param name="PROD_MONTH">Greater then or equal to. Example: 2019-01-01T00:00:00</param>
        /// <param name="FCTY_CODE">Equal to</param>
        /// <param name="FLW_CODE">Equal to</param>
        /// <param name="FLW_TYPE">Equal to</param>
        [HttpGet]
        [ProducesResponseType(typeof(FlwProdDay), 200)]
        public async Task<IActionResult> GetFlwProdDay(int? skip, int? top, DateTime? PROD_MONTH, DateTime? START_PROD_DAY, DateTime? END_PROD_DAY, string FCTY_CODE, string FLW_CODE, string FLW_TYPE)
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
            if (PROD_MONTH != null)
            {
                where.Add("t.PROD_MONTH = '" + PROD_MONTH.GetValueOrDefault().ToString("yyyy-MM-dd") + "'");
            }
            if (FCTY_CODE != null)
            {
                where.Add("t.FCTY_CODE = '" + FCTY_CODE + "'");
            }
            if (FLW_CODE != null)
            {
                where.Add("t.FLW_CODE = '" + FLW_CODE + "'");
            }
            if (FLW_TYPE != null)
            {
                where.Add("t.FLW_TYPE = '" + FLW_TYPE + "'");
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
            var paramSource = new SqlParameter("@sourceView", "[PDM].[FLW_PROD_DAY]");
            // t = source table/view, w = WELL_MASTER
            var paramJoinColumn = new SqlParameter("@joinColumn", "W.FCTY_CODE = t.FCTY_CODE");

            try
            {
                var response = _db.FlwProdDay.FromSql("EXEC [PDM].[P_GetDataWithRowLevelSecurity] @userName, @top, @skip, @filter, @sourceView, @joinColumn", paramUserName, paramTop, paramSkip, paramFilter, paramSource, paramJoinColumn);

                return Ok(await response.ToArrayAsync());
            }
            catch (Exception e)
            {
                _logger.LogError("Something went wrong in FlwProdDayController: " + e.Message);
                throw;
            }
        }
    }
}