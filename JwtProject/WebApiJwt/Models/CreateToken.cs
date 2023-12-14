using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace WebApiJwt.Models
{
    public class CreateToken
    {
        public string TokenCreate()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(3), signingCredentials: credentials);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
             return handler.WriteToken(token);
        }
    }
}
