using PolyPurrApp.Core.Dtos;
using SharedLibrary.Dtos;

namespace PolyPurrApp.Core.Service;

public interface IAuthenticationService
{
    Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto);
    Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken);
    Response<ClientTokenDto> CreateTokenByClient(ClientLoginDto clientLoginDto);

    Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken);


}