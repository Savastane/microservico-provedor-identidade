namespace Security.API.Domain.EventStore
{
    public class EventStore
    {
        private readonly Dictionary<Guid, List<Event>> _events = new Dictionary<Guid, List<Event>>();

        public void AppendEvent(Guid aggregateId, Event @event)
        {
            if (!_events.ContainsKey(aggregateId))
            {
                _events[aggregateId] = new List<Event>();
            }

            _events[aggregateId].Add(@event);
        }

        public IEnumerable<Event> GetEventsForAggregate(Guid aggregateId)
        {
            if (_events.ContainsKey(aggregateId))
            {
                return _events[aggregateId];
            }
            else
            {
                return new List<Event>();
            }
        }
    }
}
