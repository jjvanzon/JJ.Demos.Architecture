#pragma warning disable CS1572 // param tag matches no parameter

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