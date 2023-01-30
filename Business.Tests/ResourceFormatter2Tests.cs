using JJ.Demos.Architecture.Business.StringResources;
using JJ.Framework.Common;

namespace JJ.Demos.Architecture.Business.Tests;

public class ResourceFormatter2Tests
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
                string actual = ResourceFormatter2.Save;
                Assert.Equal(expected, actual);
            }

            {
                string expected = "Save Document";
                string actual = ResourceFormatter2.Save_WithName("Document");
                Assert.Equal(expected, actual);
            }
        }
        finally
        {
            CultureHelper.SetCurrentCultureName(originalCultureName);
        }
    }
}
