namespace Omu.Awem.Helpers
{
    /// <summary>
    /// Grid inline edit mod editor element
    /// </summary>
    public class InlElem
    {
        /// <summary>
        /// html format
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// js format
        /// </summary>
        public string JsFormat { get; set; }

        /// <summary>
        /// model property used for binding in post action (save)
        /// </summary>
        public string ModelProp { get; set; }

        /// <summary>
        /// value property
        /// </summary>
        public string ValProp { get; set; }
    }
}