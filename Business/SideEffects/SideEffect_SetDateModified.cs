using JJ.Demos.Architecture.Business.Services;

namespace JJ.Demos.Architecture.Business.SideEffects;

public class SideEffect_SetDateModified : ISideEffect
{
    private readonly Product _entity;
    private readonly IDateTimeProvider _dateTimeProvider;

    public SideEffect_SetDateModified(Product entity, IDateTimeProvider dateTimeProvider)
    {
        _entity = entity;
        _dateTimeProvider = dateTimeProvider;
    }

    public void Execute() 
        => _entity.DateModified = _dateTimeProvider.UtcNow.Date;
}
