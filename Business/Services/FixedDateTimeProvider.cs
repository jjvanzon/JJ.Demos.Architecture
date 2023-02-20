namespace JJ.Demos.Architecture.Business.Services;

public class FixedDateTimeProvider : IDateTimeProvider
{
    public FixedDateTimeProvider(DateTime utcNow) 
        => UtcNow = utcNow;

    public DateTime UtcNow { get; } 
}
