using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

using Projet.API.REST.Swagger;


namespace JWT.Token
{
    public static class GenerateTokenClass
    {
        public static string GenerateToken(string name)
        {
            var token = new JwtSecurityToken(claims: new Claim[]
            {
                new Claim(ClaimTypes.Name, name)
            },
            notBefore: new DateTimeOffset(DateTime.Now).DateTime,
            expires: new DateTimeOffset(DateTime.Now.AddMinutes(60)).DateTime,
            signingCredentials: new SigningCredentials(TokenHelper.SIGNING_KEY, SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
