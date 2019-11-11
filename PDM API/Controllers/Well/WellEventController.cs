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
    public class WellEventController : ControllerBase
    {
        private PDMContext _db;
        private IUserProvider _userProvider;
        readonly ILogger _logger;

        public WellEventController(PDMContext context, IUserProvider userProvider, ILoggerFactory loggerFactory)
        {
            _db = context;
            _userProvider = userProvider;
            _logger = loggerFactory.CreateLogger("WellEventController");
        }

        /// <summary>
        /// WellEvent
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (default 1000)</param>
        /// <param name="WELL_CODE">Equal to</param>
        /// <param name="WELL_BORE_CODE">Equal to</param>
        [HttpGet]
        [ProducesResponseType(typeof(WellEvent), 200)]
        public async Task<IActionResult> GetWellEvent(int? skip, int? top, string WELL_CODE, string WELL_BORE_CODE)
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
            if (WELL_CODE != null)
            {
                where.Add("t.WELL_CODE = '" + WELL_CODE + "'");
            }
            if (WELL_BORE_CODE != null)
            {
                where.Add("t.WELL_BORE_CODE = '" + WELL_BORE_CODE + "'");
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
            var paramSource = new SqlParameter("@sourceView", "[PDM].[WELL_EVENT]");
            // t = source table/view, w = WELL_MASTER
            var paramJoinColumn = new SqlParameter("@joinColumn", "W.WELL_CODE = t.WELL_CODE");

            try
            {
                var response = _db.WellEvent.FromSql("EXEC [PDM].[P_GetDataWithRowLevelSecurity] @userName, @top, @skip, @filter, @sourceView, @joinColumn", paramUserName, paramTop, paramSkip, paramFilter, paramSource, paramJoinColumn);

                return Ok(await response.ToArrayAsync());
            }
            catch (Exception e)
            {
                _logger.LogError("Something went wrong in WellEventController: " + e.Message);
                throw;
            }
        }
    }
}