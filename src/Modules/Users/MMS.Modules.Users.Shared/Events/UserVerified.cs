using MMS.Shared.Events;

namespace MMS.Modules.Users.Shared.Events;

public record UserVerified(Guid UserId, string Email, string Nationality) : IEvent;