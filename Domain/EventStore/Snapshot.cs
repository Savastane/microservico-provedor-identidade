namespace Security.API.Domain.EventStore
{
    public class Snapshot
    {
        public Guid AggregateId { get; set; }
        public int Version { get; set; }
        public string State { get; set; }
    }
}
