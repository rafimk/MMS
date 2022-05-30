using MMS.Modules.Users.Shared.DTO;

namespace MMS.Modules.Users.Shared;

public interface IUsersModuleApi
{
    Task<UserDetailsDto> GetUserAsync(Guid userId);
    Task<UserDetailsDto> GetUserAsync(string email);
}