using System.Security.Claims;

namespace api.Extensions
{
    public static class ClaimExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            return user.Claims.SingleOrDefault(x => x.Type.Equals(ClaimTypes.GivenName))?.Value
                ?? string.Empty;
        }
    }
}
