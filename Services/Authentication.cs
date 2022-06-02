
using ECommerceProject.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ECommerceProject.Services
{
    public class Authentication : IAuthenticationService
    {
        private readonly IUserRepository _userReponsitory;

        //private readonly IEnumerable<User> users = _userReponsitory.GetUser();

        private readonly Dictionary<string, string> user = new Dictionary<string, string>
        {
            {"Test1", "password1"},
            {"admin", "123456" }
        };
        private readonly String key;
        public Authentication(String key)
        {
            this.key = key;
        }
        public string Authenticate(string username, string password)
        {
            if(!user.Any(u => u.Key == username && u.Value == password))
            {
                return null;
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, username),
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
