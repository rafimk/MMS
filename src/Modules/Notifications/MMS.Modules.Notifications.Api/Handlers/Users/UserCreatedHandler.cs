using MMS.Modules.Notifications.Api.Services;
using MMS.Modules.Users.Shared.Events;
using MMS.Shared.Events;

namespace MMS.Modules.Notifications.Api.Handlers.Users;

internal sealed class UserCreatedHandler : IEventHandler<UserCreated>
{
    private readonly IEmailSender _emailSender;

    public UserCreatedHandler(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public Task HandleAsync(UserCreated @event, CancellationToken cancellationToken = default)
        => _emailSender.SendAsync(@event.Email, "account_created");
}