namespace JJ.Demos.Architecture.Business.StringResources.
          ResourceFormatter_WithHelper;

public static class ResourceFormatter
{
    private static readonly ResourceFormatterHelper _helper
        = new(Resources.ResourceManager);

    public static string Save => _helper.GetText();

    public static string Save_WithName(string name)
        => _helper.GetText_WithOnePlaceHolder(name);
}
