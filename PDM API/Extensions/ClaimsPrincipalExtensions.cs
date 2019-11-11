using System;
using System.Globalization;
using System.Security.Claims;

namespace PDM_API.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string FindFirstValue(this ClaimsPrincipal principal, string claimType, bool throwIfNotFound = false)
        {
            string value = principal.FindFirst(claimType)?.Value;
            if (throwIfNotFound && string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidOperationException(
                    string.Format(CultureInfo.InvariantCulture, "The supplied principal does not contain a claim of type {0}", claimType));
            }

            return value;
        }

        public static string GetObjectIdentifierValue(this ClaimsPrincipal principal, bool throwIfNotFound = true)
        {
            return principal.FindFirstValue("http://schemas.microsoft.com/identity/claims/objectidentifier", throwIfNotFound);
        }
    }
}
