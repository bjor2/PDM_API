using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Azure.KeyVault;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureKeyVault;

namespace PDM_API.Extensions
{
    public static class WebHostBuilderExtensions
    {
        public static IConfigurationBuilder UseAzureKeyVaultConfiguration(this IConfigurationBuilder builder)
        {
            var config = builder.Build();
            string keyVaultUrl = config["KeyVaultUrl"];
            if (!string.IsNullOrEmpty(keyVaultUrl))
            {
                var azureServiceTokenProvider = new AzureServiceTokenProvider();
                var kvClient = new KeyVaultClient(
                    (authority, resource, scope) => azureServiceTokenProvider.KeyVaultTokenCallback(authority, resource, scope));
                builder.AddAzureKeyVault(keyVaultUrl, kvClient, new DefaultKeyVaultSecretManager());
            }
            return builder;
        }
    }
}
