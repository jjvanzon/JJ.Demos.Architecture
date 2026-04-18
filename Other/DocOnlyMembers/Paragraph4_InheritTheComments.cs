class InheritDocFromBase
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
