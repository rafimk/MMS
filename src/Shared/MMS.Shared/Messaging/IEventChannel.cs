using System.Threading.Channels;
using MMS.Shared.Events;

namespace MMS.Shared.Messaging;

internal interface IEventChannel
{
    ChannelReader<IEvent> Reader { get; }
    ChannelWriter<IEvent> Writer { get; }
}