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