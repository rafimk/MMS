using MMS.Modules.Notifications.Api.Services;
using MMS.Modules.Users.Shared.Events;
using MMS.Shared.Events;

namespace MMS.Modules.Notifications.Api.Handlers.Users;

internal sealed class UserVerifiedHandler : IEventHandler<UserVerified>
{
    private readonly IEmailSender _emailSender;

    public UserVerifiedHandler(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public Task HandleAsync(UserVerified @event, CancellationToken cancellationToken = default)
        => _emailSender.SendAsync(@event.Email, "account_verified");
}