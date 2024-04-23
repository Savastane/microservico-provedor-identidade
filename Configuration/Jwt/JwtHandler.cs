using Application.Library.Security.Jwt.Model;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Library.Security.Jwt
{
    public class JwtHandler
    {
        public const string JWT_AUDIENCIE = "school-app";
        public const string JWT_ISSUER = "https://minhaaplicacao.com";
        public const string JWT_SECURITY_KEY = "93021a930129302930219329130920392198A32910839028390";
        private const int JWT_TOKEN_VALIDITY_MINS = 20;

        public JwtHandler()
        {

        }

        public AuthenticationRespose? GenerateToken(AuthenticationRequest request)
        {

            var tokenExpiryTimeStamp = DateTime.Now.AddMinutes(JWT_TOKEN_VALIDITY_MINS);

            var tokenKey = Encoding.ASCII.GetBytes(JWT_SECURITY_KEY);

            var claimsIdentity = new ClaimsIdentity(new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Name, request.UserName),
                new Claim(ClaimTypes.Role, request.Role),
                new Claim(ClaimTypes.Email, request.Email)

            });

            var claims = new List<Claim>();
            claims.Add(new Claim(JwtRegisteredClaimNames.Name, request.UserName));
            claims.Add(new Claim(ClaimTypes.Email, request.Email));
            claims.Add(new Claim(ClaimTypes.Role, request.Role));
            //new Claim("UserId",  request.UserId),
            //new Claim("AplicationId",  request.AplicationId ),
            //new Claim("organizationId",  request.OrganizationId)

            //new Claim("OrganizationName",  request.Id

            var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature);

            //var securityTokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = claimsIdentity,
            //    Expires = tokenExpiryTimeStamp,                
            //    SigningCredentials = signingCredentials
            //};

            var tokenOptions = new JwtSecurityToken(

                issuer: JWT_ISSUER,
                claims: claims,
                expires: tokenExpiryTimeStamp,
                signingCredentials: signingCredentials
            );

            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            try
            {

                //var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
                //var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
                //var token = jwtSecurityTokenHandler.WriteToken(securityToken);

                return new AuthenticationRespose
                {
                    Email = request.Email,
                    UserName = request.UserName,
                    ExpiresIn = (int)tokenExpiryTimeStamp.Subtract(DateTime.Now).TotalSeconds,
                    JwtToken = token
                };

            }
            catch (Exception e)
            {
                return null;

            }







        }
    }
}

