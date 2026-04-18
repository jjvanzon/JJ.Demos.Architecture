#pragma warning disable IDE0051 // Unused member

interface RepeatedComments
{
    /// <summary>
    /// Takes the part of a string until the specified delimiter.
    /// Excludes the delimiter itself.
    /// </summary>
    string TakeStartUntil(string input, string until);

    /// <summary>
    /// Takes the part of a string until the specified delimiter.
    /// Excludes the delimiter itself.
    /// </summary>
    string TakeStartUntil(string input, char until);
}
