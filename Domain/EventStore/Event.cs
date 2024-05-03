namespace Security.API.Domain.EventStore
{
    public class Event
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime Timestamp { get; } = DateTime.UtcNow;
        public string Type { get; }
        public object Data { get; }

        public Event(string type, object data)
        {
            Type = type;
            Data = data;
        }
    }
}
