namespace JJ.Demos.Architecture.Business.StringResources;

public static class ResourceFormatter2
{
    private static readonly ResourceFormatterHelper _helper 
        = new (Resources.ResourceManager);

    public static string Save => _helper.GetText();

    public static string Save_WithName(string name) 
        => _helper.GetText_WithOnePlaceHolder(name);
}
