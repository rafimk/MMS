using MMS.Shared.Events;

namespace MMS.Modules.Users.Shared.Events;

public record UserCreated(Guid UserId, string Email, string FullName, string Nationality) : IEvent;