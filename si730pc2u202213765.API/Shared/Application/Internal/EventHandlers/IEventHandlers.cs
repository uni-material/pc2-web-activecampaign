using Cortex.Mediator.Notifications;
using si730pc2u202213765.API.Shared.Domain.Model.Events;

namespace si730pc2u202213765.API.Shared.Application.Internal.EventHandlers;

public interface IEventHandlers<in TEvent> : INotificationHandler<TEvent> where TEvent : IEvent
{
    
}