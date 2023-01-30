namespace JJ.Demos.Architecture.Business.StringResources;

public static class ResourceFormatter1
{
    public static string Save_WithName(string name) 
        => string.Format(Resources.Save_WithName, name);
}
