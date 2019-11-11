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
    public class ImsTagMappingController : ControllerBase
    {
        private PDMContext _db;

        public ImsTagMappingController(PDMContext context)
        {
            _db = context;
        }

        /// <summary>
        /// ImsTagMapping
        /// </summary>
        /// <returns></returns>
        /// <param name="skip">The amount of records you want to skip</param>
        /// <param name="top" >The amount of records you want returned (default 1000)</param>
        /// <param name="columns">Columns to return. Example: Column1,Column2</param>
        /// <param name="TAG_ID">Equal to</param>
        /// <param name="SOURCE_ID">Equal to</param>
        /// <param name="DBSOURCE_ID">Equal to</param>
        [HttpGet]
        [ProducesResponseType(typeof(ImsTagMapping), 200)]
        public async Task<IActionResult> GetImsTagMapping(int? skip, int? top, string columns, string TAG_ID, string SOURCE_ID, string DBSOURCE_ID)
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
            ImsTagMapping obj = new ImsTagMapping();
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
            var result = _db.ImsTagMapping
                .Where(e =>
                    (e.TAG_ID == TAG_ID || TAG_ID == null)
                    && (e.SOURCE_ID == SOURCE_ID || SOURCE_ID == null)
                    && (e.DBSOURCE_ID == DBSOURCE_ID || DBSOURCE_ID == null)
                )
                .Skip(s)
                .Take(t)
				.Select("new(" + columns + ")");
 
            return Ok(await result.ToDynamicListAsync());
        }
    }
}