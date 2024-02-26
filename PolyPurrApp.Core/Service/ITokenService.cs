using PolyPurrApp.Core.Configuration;
using PolyPurrApp.Core.Dtos;
using PolyPurrApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyPurrApp.Core.Service
{
    public interface ITokenService
    {
        TokenDto CreateToken(User user);
        ClientTokenDto CreateTokenByClient(Client client);
    }
}
