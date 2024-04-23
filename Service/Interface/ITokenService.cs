using System;
using System.API.Application;
using systemsecurity.domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.API.Service.Interface
{
    public interface ITokenService
    {
        Task<string> Gerar(User user);
        Task<string> Gerar(User user, string issuer);

        Task<string> GerarTokenAmbiente(string email, string id, string usuario, string role, string idaplicacao, string idorganizcao, string organizacao, string issuer);

        
    }
}
