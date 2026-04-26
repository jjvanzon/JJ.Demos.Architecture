#pragma warning disable IDE1006 // Naming Styles
// ReSharper disable UnassignedGetOnlyAutoProperty

// Docs Namespace

namespace JJ.Demos.Architecture;

using docs;

/// <inheritdoc cref="_element" />
class Element;

/// <summary>
/// See the inheritdocs in <see cref="ComplexGenericCref" />.
/// </summary>
class Structs;

class Public
{
    /// <summary>...</summary>
    public struct _element;
}

class NamingStyle
{
    /// <summary> ... </summary>
    struct _myprop;

    /// <inheritdoc cref="_myprop" />
    int MyProp { get; }
}