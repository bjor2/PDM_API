using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    [ApiExplorerSettings(GroupName = "internal")]
    public class WellMasterController : ControllerBase
    {
        private PDMContext _db;
        private IUserProvider _userProvider;
        readonly ILogger _logger;

        public WellMasterController(PDMContext context, IUserProvider userProvider, ILoggerFactory loggerFactory)
        {
            _db = context;
            _userProvider = userProvider;
            _logger = loggerFactory.CreateLogger("WellProdDayController");
        }

        /// <summary>
        /// WellMaster
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (default 1000)</param>
        /// <param name="WELL_OFFICIAL_NAME">Equal to</param>
        /// <param name="WELL_CODE">Equal to</param>
        /// <param name="WELL_START_DATE">Greater then or equal to. Example: 2019-01-01T00:00:00</param>
        [HttpGet]
        [ProducesResponseType(typeof(WellMaster), 200)]
        public async Task<IActionResult> GetWellMaster(int? skip, int? top, string WELL_OFFICIAL_NAME, string WELL_CODE, DateTime? WELL_START_DATE)
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
            if (WELL_OFFICIAL_NAME != null)
            {
                where.Add("t.WELL_OFFICIAL_NAME = '" + WELL_OFFICIAL_NAME + "'");
            }
            if (WELL_CODE != null)
            {
                where.Add("t.WELL_CODE = '" + WELL_CODE + "'");
            }
            if (WELL_START_DATE != null)
            {
                where.Add("t.WELL_START_DATE = '" + WELL_START_DATE.GetValueOrDefault().ToString("yyyy-MM-dd") + "'");
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
            var paramSource = new SqlParameter("@sourceView", "[PDM].[WELL_MASTER]");
            // t = source table/view, w = WELL_MASTER
            var paramJoinColumn = new SqlParameter("@joinColumn", "W.FCTY_CODE = t.FCTY_CODE");

            try
            {
                var response = _db.WellMaster.FromSql("EXEC [PDM].[P_GetDataWithRowLevelSecurity] @userName, @top, @skip, @filter, @sourceView, @joinColumn", paramUserName, paramTop, paramSkip, paramFilter, paramSource, paramJoinColumn);

                return Ok(await response.ToArrayAsync());
            }
            catch (Exception e)
            {
                _logger.LogError("Something went wrong in WellMasterController: " + e.Message);
                throw;
            }
        }
    }
}