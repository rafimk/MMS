﻿using MMS.Modules.Users.Shared;
using MMS.Modules.Users.Shared.DTO;

namespace MMS.Modules.Users.Core.Services;

internal sealed class UsersModuleApi : IUsersModuleApi
{
    private readonly IUsersService _usersService;

    public UsersModuleApi(IUsersService usersService)
    {
        _usersService = usersService;
    }

    public Task<UserDetailsDto> GetUserAsync(Guid userId) => _usersService.GetAsync(userId);
        
    public Task<UserDetailsDto> GetUserAsync(string email) => _usersService.GetAsync(email);
}