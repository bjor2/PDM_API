using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PDM_API.Models;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace PDM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Pdm.Member")]
    [ApiExplorerSettings(GroupName = "internal")]
    public class IonCombController : ControllerBase
    {
        private PDMContext _db;
        readonly ILogger _logger;

        public IonCombController(PDMContext context, ILoggerFactory loggerFactory)
        {
            _db = context;
            _logger = loggerFactory.CreateLogger("IonCombController");
        }

        /// <summary>
        /// IonComb
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (default 1000)</param>
        /// <param name="columns">Columns to return. Example: Column1,Column2</param>
        [HttpGet]
        [ProducesResponseType(typeof(IonComb), 200)]
        public async Task<IActionResult> GetIonComb(int? skip, int? top, string columns)
        {
            int s = (skip == null) ? 0 : skip.GetValueOrDefault();
            int t = (top == null) ? 1000 : top.GetValueOrDefault();

            if (s < 0)
                return BadRequest("Skip can't be a negative number");

            if (t < 1)
                return BadRequest("Top can't be less then 1");

            if (columns != null)
                columns = columns.Replace(" ", "");

            /* This section is used to check the existence of columns suplied in the request,
             * and in the event of no columns being supplied finds a list of each column of the given model.
             */
            IonComb obj = new IonComb();
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

            var result = _db.IonComb
                .Where(e => (true))
                .Skip(s)
                .Take(t)
                .Select("new(" + columns + ")");

            return Ok(await result.ToDynamicListAsync());
        }
    }
}
