#pragma warning disable CS1572 // XML comment has a param tag, but there is no parameter by that name
#pragma warning disable IDE0060 // Unused parameter
// ReSharper disable ArrangeTypeModifiers
// ReSharper disable UnusedParameter.Local
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable UnusedType.Local
// ReSharper disable MemberCanBeProtected.Local
// ReSharper disable InvalidXmlDocComment
// ReSharper disable UnassignedGetOnlyAutoProperty

namespace JJ.Demos.Architecture;

using docs;

class WithoutDocComment
{
    string StartWithCap(string input)
    {
        if (input.Length == 0) return input;
        return input.Left(1).ToUpper() + input.CutLeft(1);
    }
 }

class WithDocComment
{
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

class CrowdedComments
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
    /// Takes the part of a string until the specified delimiter.
    /// Excludes the delimiter itself.
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
    /// Takes the part of a string until the specified delimiter.
    /// Excludes the delimiter itself.
    /// </summary>
    string TakeStartUntil(string input, char until)
    {
        return TakeStartUntil(input, until.ToString());
    }
}

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

class InheritDocWithInheritance
{
    /// <inheritdoc />
    class Rectangle : Element
    {
        /// <inheritdoc />
        Rectangle(Element parent) : base(parent) { }
    }

    /// <summary>
    /// VectorGraphics element that can contain
    /// VectorGraphics child elements.
    /// </summary>
    class Element
    {
        /// <summary>
        /// VectorGraphics element that can contain
        /// VectorGraphics child elements.
        /// </summary>
        /// <param name="parent">
        /// When in doubt, use Diagram.Background.
        /// </param>
        public Element(Element parent) { }
    }
}

class InheritDocInConstructor
{
    /// <inheritdoc />
    class Rectangle : Element
    {
        /// <inheritdoc />
        Rectangle(Element parent) : base(parent) { }
    }

    /// <summary>
    /// VectorGraphics element that can contain
    /// VectorGraphics child elements.
    /// </summary>
    /// <param name="parent">
    /// When in doubt, use Diagram.Background.
    /// </param>
    class Element
    {
        /// <inheritdoc cref="Element" />
        public Element(Element parent) { }
    }
}

class ReferencesDocsCs
{
    /// <inheritdoc cref="_element" />
    class Rectangle : Element
    {
        /// <inheritdoc cref="_element" />
        Rectangle(Element parent) : base(parent) { }
    }

    /// <inheritdoc cref="_element" />
    class Element
    {
        /// <inheritdoc cref="_element" />
        public Element(Element parent) { }
    }
}


class NamingStyle
{
    /// <inheritdoc cref="_myprop" />
    int MyProp { get; }
}

public class MissingDoc
{
    public void MyMethod()
    {
    }
}

class Bewilder_BeforeCref
{
    /// <inheritdoc cref="Merge{TKey}(Dictionary{TKey,IValidator},Dictionary{TKey,IValidator})" />
    Dictionary<TKey, ValidatorBase<T>> Merge<TKey, T>(
        Dictionary<TKey, ValidatorBase<T>> first, 
        Dictionary<TKey, ValidatorBase<T>> second)
        where TKey : notnull
    {
        #region
        var result = new Dictionary<TKey, ValidatorBase<T>>(first);
        foreach (var entry in second)
        {
            result[entry.Key] = entry.Value;
        }
        return result;
        #endregion
    }

    /// <summary>
    /// Merges two collections into one.
    /// When collections are empty, an empty collection is returned.
    /// </summary>
    Dictionary<TKey, IValidator> Merge<TKey>(
        Dictionary<TKey, IValidator> first, 
        Dictionary<TKey, IValidator> second)
        where TKey : notnull
    {
        #region
        var result = new Dictionary<TKey, IValidator>(first);
        foreach (var entry in second)
        {
            result[entry.Key] = entry.Value;
        }
        return result;
        #endregion
    }
}

class Bewilder_AfterDocOnlyMembers
{
    /// <inheritdoc cref="_merge" />
    Dictionary<TKey, ValidatorBase<T>> Merge<TKey, T>(
        Dictionary<TKey, ValidatorBase<T>> first, 
        Dictionary<TKey, ValidatorBase<T>> second)
        where TKey : notnull
    {
        #region
        var result = new Dictionary<TKey, ValidatorBase<T>>(first);
        foreach (var entry in second)
        {
            result[entry.Key] = entry.Value;
        }
        return result;
        #endregion
    }

    /// <inheritdoc cref="_merge" />
    Dictionary<TKey, IValidator> Merge<TKey>(
        Dictionary<TKey, IValidator> first, 
        Dictionary<TKey, IValidator> second)
        where TKey : notnull
    {
        #region
        var result = new Dictionary<TKey, IValidator>(first);
        foreach (var entry in second)
        {
            result[entry.Key] = entry.Value;
        }
        return result;
        #endregion
    }
}

interface IValidator;
class ValidatorBase<T> : IValidator;
