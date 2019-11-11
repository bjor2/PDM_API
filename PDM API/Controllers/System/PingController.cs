using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PDM_API.Models;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace PDM_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        readonly ILogger _logger;
        readonly HealthCheckService _healthService;

        public PingController(ILogger<PingController> logger, HealthCheckService healthService)
        {
            _logger = logger;
            _healthService = healthService;
        }

        /// <summary>
        /// Ping
        /// </summary>
        /// <description>
        /// Health check endpoint
        /// </description>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(HealthModel), 200)]
        public async Task<IActionResult> Ping()
        {
            var response = new HealthModel();

            try
            {
                response.Version = Assembly.GetEntryAssembly().GetName().Version.ToString();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unable to get version");
            }

            response.DatabaseCheckPassed = await _healthService.CheckDbConnectionAsync();

            return Ok(response);
        }
    }
}