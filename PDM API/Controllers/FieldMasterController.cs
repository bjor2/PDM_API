using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PDM_API.Models;

namespace PDM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Pdm.Member")]
    [ApiExplorerSettings(GroupName = "internal")]
    public class FieldMasterController : ControllerBase
    {
        private PDMContext _db;
        readonly ILogger _logger;

        public FieldMasterController(ILogger<FieldMasterController> logger, PDMContext context)
        {
            _logger = logger;
            _db = context;
        }

        /// <summary>
        /// FieldMaster
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (default 1000)</param>
        /// <param name="columns">Columns to return. Example: Column1,Column2</param>
        /// <param name="FIELD_ID_EC">Equal to</param>
        /// <param name="FIELD_V_START_DATE">Greater then or equal to. Example: 2019-01-01T00:00:00</param>
        /// <param name="DBSOURCE_ID">Equal to</param>
        [HttpGet]
        [ProducesResponseType(typeof(FieldMaster), 200)]
        public async Task<IActionResult> GetFieldMaster(int? skip, int? top, string columns, string FIELD_ID_EC, DateTime? FIELD_V_START_DATE, string DBSOURCE_ID)
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
                FieldMaster obj = new FieldMaster();
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
            var result = _db.FieldMaster
                    .Where(e =>
                        (e.FIELD_ID_EC == FIELD_ID_EC || FIELD_ID_EC == null)
                        && (e.FIELD_V_START_DATE >= FIELD_V_START_DATE || FIELD_V_START_DATE == null)
                        && (e.DBSOURCE_ID == DBSOURCE_ID || DBSOURCE_ID == null)
                    )
                    .Skip(s)
                    .Take(t)
                    .Select("new(" + columns + ")");

                var response = await result.ToDynamicListAsync();

                return Ok(response);
            }
            catch (Exception e)
            {
                
                _logger.LogError($"Something went wrong in GetFieldMaster: {e.Message}. Stacktrace: {e.StackTrace}");
                return StatusCode(500);
            }
        }
    }
}