namespace JJ.Demos.Architecture.Business.Factory;

interface IThing { }
class NormalThing : IThing { }
class SpecialThing : IThing { }

static class ThingFactory
{
    static IThing CreateThing(int parameter)
    {
        switch (parameter)
        {
            case 0: return new NormalThing();

            case 1: return new SpecialThing();

            default: throw new NotSupportedException();
        }
    }
}