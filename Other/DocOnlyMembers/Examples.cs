#pragma warning disable CS1572 // XML comment has a param tag, but there is no parameter by that name
// ReSharper disable UnusedTypeParameter
// ReSharper disable InvalidXmlDocComment
// ReSharper disable UnassignedGetOnlyAutoProperty

namespace JJ.Demos.Architecture;

using docs;

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

// Errors out on purpose, but this is not nice for the CI.
/*
public class MissingDoc
{
    public void MyMethod()
    {
    }
}
*/

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

class XmlFileDocs
{
    /// <include file='docs.xml' path='docs/member[@name="Shout"]/*' />
    public string Shout(string input) => input.ToUpper() + "!";
}

class XmlCompilerFormatDocs
{
    /// <include file='ExternalShout.xml' path='doc/members/member[@name="M:JJ.Demos.Architecture.ExternalShout.Shout(System.String)"]/*' />
    string Shout(string input) => input.ToUpper() + "!";
}

class XmlCompilerFormatGenericDocs
{
    /// <include file='ExternalMerge.xml' path='doc/members/member[@name="M:JJ.Demos.Architecture.ExternalMerge.Merge``2(System.Collections.Generic.Dictionary{``0,JJ.Demos.Architecture.ValidatorBase{``1}},System.Collections.Generic.Dictionary{``0,JJ.Demos.Architecture.ValidatorBase{``1}})"]/*' />
    Dictionary<TKey, ValidatorBase<T>> Merge<TKey, T>(
        Dictionary<TKey, ValidatorBase<T>> first,
        Dictionary<TKey, ValidatorBase<T>> second)
        where TKey : notnull
    {
        #region
        var result = new Dictionary<TKey, ValidatorBase<T>>(first);
        foreach (var entry in second)
            result[entry.Key] = entry.Value;
        return result;
        #endregion
    }
}

/// <summary>
/// The legacy shall be respected!
/// </summary>
/// <inheritdoc cref="_mylegacyclass" />
public class MyLegacyClass;

#pragma warning disable CS1573 // Parameter has no matching param tag (intentional demonstration)
/// <summary>
/// Demonstrates CS1573 warning: missing param tag on public method.
/// Intentionally has a &lt;param&gt; tag for a non-existent parameter,
/// but missing one for the actual parameter to trigger CS1573.
/// </summary>
/// <param name="unused">This param is documented.</param>
public class TriggerCs1573
{
    /// <summary>
    /// Returns the input string as-is.
    /// </summary>
    /// <param name="other">The string to echo. This param exists but we won't document it for input parameter.</param>
    public string MissingParamTag(string input) => input;
}
#pragma warning restore CS1573

/// <summary>
/// Shows that &lt;inheritdoc cref&gt; does NOT inherit &lt;param&gt; tags.
/// Even though _missingparamtag has a &lt;param name="param1"&gt; tag,
/// it's not inherited here. CS1573 won't trigger because the method
/// has zero &lt;param&gt; tags (the compiler doesn't see "some but not all").
/// </summary>
public class MissingParamClass
{
    /// <inheritdoc cref="_missingparamtag" />
    public void MissingParamTag(int param1, int param2) { }
}

#pragma warning disable CS1573 // Intentional: demonstrating include param inheritance
/// <summary>
/// Demonstrates that &lt;include&gt; can pull in parameter documentation from XML.
/// </summary>
public class XmlFileDocsMissingParam
{
    /// <summary>
    /// Demonstrates that &lt;include&gt; DOES inherit and validate &lt;param&gt; tags.
    /// The XML includes &lt;param name="input"&gt;, so extra parameter 'extra' is caught as CS1573.
    /// This contrasts with &lt;inheritdoc cref&gt; which does NOT inherit param tags.
    /// </summary>
    /// <include file='docsmissingparam.xml' path='docs/member[@name="Shout"]/*' />
    public string ShoutWithExtra(string input, string extra) => input.ToUpper() + "!";
}
#pragma warning restore CS1573

