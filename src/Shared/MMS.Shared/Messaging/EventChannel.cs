﻿using System.Threading.Channels;
using MMS.Shared.Events;

namespace MMS.Shared.Messaging;

internal sealed class EventChannel : IEventChannel
{
    private readonly Channel<IEvent> _messages = Channel.CreateUnbounded<IEvent>();

    public ChannelReader<IEvent> Reader => _messages.Reader;
    public ChannelWriter<IEvent> Writer => _messages.Writer;
}