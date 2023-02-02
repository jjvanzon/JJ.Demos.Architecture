namespace JJ.Demos.Architecture.Business.StringResources.
          ResourceFormatter_WithStringFormat;

public static class ResourceFormatter
{
    public static string Save_WithName(string name) 
        => string.Format(Resources.Save_WithName, name);
}
