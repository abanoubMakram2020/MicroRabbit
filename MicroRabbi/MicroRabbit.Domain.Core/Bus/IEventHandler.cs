using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent>: IEventHandler
        where TEvent:Event
    {
    }

    public interface IEventHandler
    {

    }
}
