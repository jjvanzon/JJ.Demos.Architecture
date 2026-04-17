#pragma warning disable CS1572 // param tag mismatch
#pragma warning disable IDE0130 // Namespace != folder
#pragma warning disable IDE1006 // Naming Styles
// ReSharper disable UnusedType.Global

namespace JJ.Demos.Architecture.docs;

/// <summary>
/// VectorGraphics element that can contain
/// VectorGraphics child elements.
/// </summary>
/// <param name="parent">
/// When in doubt, use Diagram.Background.
/// </param>
struct _element;

/// <summary> ... </summary>
struct _myprop;

/// <summary>
/// Merges two lists into one.
/// When lists are empty, an empty list is returned.
/// </summary>
struct _merge;

/// <summary>
/// Specifies the logger type. Options include:
/// <list type="bullet">
/// <item>LoggerEnum values (e.g., Console, DebugOutput).</item>
/// <item>Assembly name containing an ILogger implementation.</item>
/// <item>Full .NET Type string indicating an implementation of ILogger.</item>
/// </list>
/// </summary>
public struct _loggertype;

/// <inheritdoc cref="_loggertype" />
/// <remarks>Multiple values allowed separated by semi-colons.</remarks>
public struct _loggertypes;

/// <remarks>
/// But remarks are awesome!
/// </remarks>
public struct _mylegacyclass;

/// <summary>
/// This is a summary.
/// </summary>
/// <param name="param1">
/// I am param1. I am a good param.
/// </param>
public struct _missingparamtag;