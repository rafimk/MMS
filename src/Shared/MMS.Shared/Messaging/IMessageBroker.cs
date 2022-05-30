using MMS.Shared.Events;

namespace MMS.Shared.Messaging;

public interface IMessageBroker
{
    Task PublishAsync(IEvent @event, CancellationToken cancellationToken = default);
}