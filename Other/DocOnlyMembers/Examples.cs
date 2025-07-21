// ReSharper disable ArrangeTypeModifiers

namespace JJ.Demos.Architecture.Other.DocOnlyMembers;

class DocOnlyMembers_Example_WithoutDocComment
{
    // Without Doc Comment

    string StartWithCap(string input)
    {
        if (input.Length == 0) return input;
        return input.Left(1).ToUpper() + input.CutLeft(1);
    }
 }

class DocOnlyMembers_Example_WithDocComment
{
    // With Doc Comment

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

    void MyCode()
    {
        var output = StartWithCap("test");
    }
}

class DocOnlyMembers_Example_CrowdedWithComments
{
    /// <summary>
    /// Returns the left part of a string.
    /// Can return less characters than the length provided if string is shorter.
    /// </summary>
    string TakeStart(string input, int length)
    {
        if (length > input.Length) length = input.Length;
        return input.Left(length);
    }

    /// <summary>
    /// Takes the part of a string until the specified delimiter. Excludes the delimiter itself.
    /// </summary>
    string TakeStartUntil(string input, string until)
    {
        if (until == null) throw new ArgumentNullException(nameof(until));
        int index = input.IndexOf(until, StringComparison.Ordinal);
        if (index == -1) return "";
        string output = input.Left(index);
        return output;
    }

    /// <summary>
    /// Takes the part of a string until the specified delimiter. Excludes the delimiter itself.
    /// </summary>
    string TakeStartUntil(string input, char until) 
        => TakeStartUntil(input, until.ToString());
}

interface DocOnlyMembers_Example_RepeatedDocComment
{
    /// <summary>
    /// Takes the part of a string until the specified delimiter. Excludes the delimiter itself.
    /// </summary>
    string TakeStartUntil(string input, string until);

    /// <summary>
    /// Takes the part of a string until the specified delimiter. Excludes the delimiter itself.
    /// </summary>
    string TakeStartUntil(string input, char until);
}