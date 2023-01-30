namespace JJ.Demos.Architecture.Business.Tests;

public class ResourceFormatter1Tests
{
    [Fact]
    public void Test_ResourceFormatter1()
    {
        string originalCultureName = CultureHelper.GetCurrentCultureName();
        try
        {
            CultureHelper.SetCurrentCultureName("en-US");

            string expected = "Save Document";
            string actual = ResourceFormatter1.Save_WithName("Document");
            Assert.Equal(expected, actual);
        }
        finally
        {
            CultureHelper.SetCurrentCultureName(originalCultureName);
        }
    }
}
