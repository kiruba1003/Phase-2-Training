using JWT_Auth.Services.Interface;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT_Auth.Services
{
    public class TokenService : IToken
    {
        //to read appsettings data
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(string username, string role)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");

           // var tokenkey = Encoding.UTF8.GetBytes("Token Key");
           // var tokenkey = Encoding.UTF8.GetBytes(_configuration["JwtSettings:Token Key"]);
           var tokenkey = Encoding.ASCII.GetBytes("This is kiruba you.... ");

            //Console.WriteLine(tokenkey);
            var issuer = jwtSettings["Issuer"];
            //var epires= DateTime.UtcNow.Addminutes(5);

            //security package -  it will authorize us
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, username),//nameidentifier - act as primary keyno duplicate
                new Claim(ClaimTypes.Role,role)

            };

            //token descriptor
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Issuer = issuer,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha512)

            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);

        }
    }
}
