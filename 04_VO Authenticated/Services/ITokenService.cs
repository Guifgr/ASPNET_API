using System.Collections.Generic;
using System.Security.Claims;

namespace APIRest_ASPNET5.Services
{
    public interface ITokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredTokens(string token);
    }
}