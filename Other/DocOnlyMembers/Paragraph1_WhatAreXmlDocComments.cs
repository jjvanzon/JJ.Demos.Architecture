class WithDocComment
{
    void MyCode()
    {
        var output = StartWithCap("test");
    }

    /// <summary>
    /// Changes the first character to upper case:
    /// <code>
    /// StartWithCap("test") = "Test"
    /// </code>
    /// </summary>
    string StartWithCap(string input)
    {
        if (input.Length == 0) return input;
        return input.Left(1).ToUpper() + input.CutLeft(1);
    }
}

class WithoutDocComment
{
    string StartWithCap(string input)
    {
        if (input.Length == 0) return input;
        return input.Left(1).ToUpper() + input.CutLeft(1);
    }
 }
