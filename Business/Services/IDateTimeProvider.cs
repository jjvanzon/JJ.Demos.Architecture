namespace JJ.Demos.Architecture.Business.Services;

public interface IDateTimeProvider 
{
    DateTime UtcNow { get; }
}
