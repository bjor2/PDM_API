using PDM_API.Models.Auth;
using System.Threading.Tasks;

namespace PDM_API.Providers
{
    public interface IUserProvider
    {
        Task<ProdComUser> GetUserAsync();
        string GetUserName();
        Task<ProdComUser> GetUserAsync(string userName);
    }
}
