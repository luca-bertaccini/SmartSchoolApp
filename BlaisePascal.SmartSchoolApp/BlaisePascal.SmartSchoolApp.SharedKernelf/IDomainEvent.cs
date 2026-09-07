namespace BlaisePascal.SmartSchoolApp.SharedKernel
{
    public interface IDomainEvent
    {
        DateTime OccurredOnUtc { get; init; }
    }

    public abstract class DomainEvent : IDomainEvent
    {
        public DateTime OccurredOnUtc { get; init; } = DateTime.UtcNow;
        public DomainEvent()
        {
            OccurredOnUtc = DateTime.UtcNow;
        }

    }
}
