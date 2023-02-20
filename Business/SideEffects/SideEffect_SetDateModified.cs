namespace JJ.Demos.Architecture.Business.SideEffects;

public class SideEffect_SetDateModified : ISideEffect
{
    private readonly Product _entity;

    public SideEffect_SetDateModified(Product entity)
        => _entity = entity;

    public void Execute() 
        => _entity.DateModified = DateTime.UtcNow.Date;
}
