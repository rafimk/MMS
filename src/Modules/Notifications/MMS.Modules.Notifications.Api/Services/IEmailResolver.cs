﻿namespace MMS.Modules.Notifications.Api.Services;

internal interface IEmailResolver
{
    string GetForOwner(Guid ownerId);
}