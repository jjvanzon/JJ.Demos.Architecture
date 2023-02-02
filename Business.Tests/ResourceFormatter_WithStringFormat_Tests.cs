using JJ.Demos.Architecture.Business.StringResources.
      ResourceFormatter_WithStringFormat;

namespace JJ.Demos.Architecture.Business.Tests;

public class ResourceFormatter_WithStringFormat_Tests
{
    [Fact]
    public void Test_ResourceFormatter1()
    {
        string originalCultureName = CultureHelper.GetCurrentCultureName();
        try
        {
            CultureHelper.SetCurrentCultureName("en-US");

            string expected = "Save Document";
            string actual = ResourceFormatter.Save_WithName("Document");
            Assert.Equal(expected, actual);
        }
        finally
        {
            CultureHelper.SetCurrentCultureName(originalCultureName);
        }
    }
}
