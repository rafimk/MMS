﻿namespace MMS.Modules.Notifications.Api.Services;

internal interface IEmailSender
{
    Task SendAsync(string receiver, string template);
}