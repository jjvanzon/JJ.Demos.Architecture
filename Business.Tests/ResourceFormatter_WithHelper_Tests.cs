using JJ.Demos.Architecture.Business.StringResources.
      ResourceFormatter_WithHelper;

namespace JJ.Demos.Architecture.Business.Tests;

public class ResourceFormatter_WithHelper_Tests
{
    [Fact]
    public void Test_ResourceFormatter2()
    {
        string originalCultureName = CultureHelper.GetCurrentCultureName();
        try
        {
            CultureHelper.SetCurrentCultureName("en-US");

            {
                string expected = "Save";
                string actual = ResourceFormatter.Save;
                Assert.Equal(expected, actual);
            }

            {
                string expected = "Save Document";
                string actual = ResourceFormatter.Save_WithName("Document");
                Assert.Equal(expected, actual);
            }
        }
        finally
        {
            CultureHelper.SetCurrentCultureName(originalCultureName);
        }
    }
}
