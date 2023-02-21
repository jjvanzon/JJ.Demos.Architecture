using JJ.Demos.Architecture.Business.Services;

namespace JJ.Demos.Architecture.Business.SideEffects;

public class SideEffect_SetDateModified : ISideEffect
{
    public static readonly DateTime FixedDateTime = DateTime.Parse("2023-02-21 23:00");

    private readonly Product _entity;
    private readonly IDateTimeProvider _dateTimeProvider;

    public SideEffect_SetDateModified(Product entity)
    {
        _entity = entity;
        _dateTimeProvider = new FixedDateTimeProvider(FixedDateTime);
    }

    public void Execute() 
        => _entity.DateModified = _dateTimeProvider.UtcNow.Date;
}
