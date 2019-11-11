// Disabled

// using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Dynamic.Core;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using PDM_API.Models;

//namespace PDM_API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    [Authorize(Policy = "Pdm.Member")]
//    public class WellTestResultInjController : ControllerBase
//    {
//        private PDMContext _db;

//        public WellTestResultInjController(PDMContext context)
//        {
//            _db = context;
//        }

//        /// <summary>
//        /// WellTestResultInj
//        /// </summary>
//        /// <returns></returns>
//        /// <param name="skip">The amount of records you want to skip</param>
//        /// <param name="top" >The amount of records you want returned (default 1000)</param>
//        /// <param name="DATEPRD">Greater then or equal to. Example: 2019-01-01T00:00:00</param>
//        /// <param name="WELL_CODE">Equal to</param>
//        /// <param name="INJ_TYPE">Equal to</param>
//        [HttpGet]
//        [ProducesResponseType(typeof({type}), 200)]
//         public async Task<IActionResult> GetWellTestResultInj(int? skip, int? top, string columns, DateTime? DATEPRD, string WELL_CODE, string INJ_TYPE)
//    {
//        int s = (skip == null) ? 0 : skip.GetValueOrDefault();
//        int t = (top == null) ? 1000 : top.GetValueOrDefault();

//        if (s < 0)
//            return BadRequest("Skip can't be a negative number");

//        if (t < 1)
//            return BadRequest("Top can't be less then 1");

//        if (columns != null)
//            columns = columns.Replace(" ", "");

//        /* This section is used to check the existence of columns suplied in the request,
//         * and in the event of no columns being supplied finds a list of each column of the given model.
//         */
//        var result = _db.WellTestResultInj
//            .Where(e =>
//                (e.DATEPRD >= DATEPRD || DATEPRD == null)
//                && (e.WELL_CODE == WELL_CODE || WELL_CODE == null)
//                && (e.INJ_TYPE == INJ_TYPE || INJ_TYPE == null)
//            )
//            .Skip(s)
//            .Take(t)
//            .Select("new(" + columns + ")");

//        return Ok(await result.ToDynamicListAsync());
//    }
//}
// }