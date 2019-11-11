using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace PDM_API
{
    public class HealthCheckService
    {
        readonly PDMContext _db;
        readonly ILogger<HealthCheckService> _logger;

        public HealthCheckService(PDMContext context, ILogger<HealthCheckService> logger)
        {
            _db = context;
            _logger = logger;
        }

        public async Task<bool> CheckDbConnectionAsync()
        {
            try
            {
                return await _db.Database.CanConnectAsync();
            }
            catch (System.Exception ex)
            {
                _logger.LogCritical(ex, "DbConnectionCheck failed");
                return false;
            }
        }
    }
}