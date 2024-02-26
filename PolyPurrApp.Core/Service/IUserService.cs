using PolyPurrApp.Core.Dtos;
using SharedLibrary.Dtos;

namespace PolyPurrApp.Core.Service;

public interface IUserService
{
    Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);
    Task<Response<UserAppDto>> GetUserByNameAsync(string userName);

}