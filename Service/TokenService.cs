using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;

using systemsecurity.domain;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.API.Service.Interface;
using Application.Library.Security.Jwt.Model;
using Application.Library.Security.Jwt;

namespace Service.Seguranca
{
    public class TokenService : ITokenService
    {
        private readonly JwtHandler _jwtHandler;

        public TokenService(JwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
        }

        public async Task<string>  Gerar(User user)
        {
            //var _jwtHandler = new JwtHandler();
            
            var resp =  _jwtHandler.GenerateToken(new AuthenticationRequest { UserName = user.Name, Email = user.Email, Role= "role." });

           return await Task.Run(() => resp.JwtToken); 
        }
    
        public async Task<string> Gerar(User user, string issuer)
        {

            //var claims = new List<Claim>();
            //var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Settings.Secret));
            //var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            //var expirationTimeStamp = DateTime.Now.AddHours(5);



            //claims.Add(new Claim(ClaimTypes.Name, user.Nome));
            //claims.Add(new Claim(ClaimTypes.Email, user.Email));
            //claims.Add(new Claim(ClaimTypes.Role, "user.Role"));


            //var tokenOptions = new JwtSecurityToken(
            //    issuer: issuer,
            //    claims: claims,
            //    expires: expirationTimeStamp,
            //    signingCredentials: signingCredentials
            //);


            //var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            //return await Task.Run(() => tokenString);
            return null;
        }
        public async Task<string> GerarTokenAmbiente(string email, string id, string usuario, string role, string idaplicacao, string idorganizcao, string organizacao, string issuer)
        {

            var claims = new List<Claim>();

            //var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Settings.Secret));
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(""));
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var expirationTimeStamp = DateTime.Now.AddHours(5);



            claims.Add(new Claim(ClaimTypes.Name, usuario));
            claims.Add(new Claim(ClaimTypes.Email, email));
            claims.Add(new Claim(ClaimTypes.Role, role));
            claims.Add(new Claim("IdUsuario", id));
            claims.Add(new Claim("IdAplicacao", idaplicacao));
            claims.Add(new Claim("IdOrganizacao", idorganizcao));
            claims.Add(new Claim("Organizacao", organizacao));

            var tokenOptions = new JwtSecurityToken(
                issuer: issuer,
                claims: claims,
                expires: expirationTimeStamp,
                signingCredentials: signingCredentials
            );

        
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return await Task.Run(() => tokenString);
        }
    }
}