namespace JJ.Demos.Architecture.Business.Factory;

public static class ThingFactory
{
    public static IThing CreateThing(int parameter)
    {
        switch (parameter)
        {
            case 0:
                return new NormalThing();
            case 1:
                return new SpecialThing();
            default:
                throw new Exception(
                    $"parameter value '{parameter}' is not supported.");
        }
    }
}

public class SpecialThing : IThing { }

public class NormalThing : IThing { }

public interface IThing { }