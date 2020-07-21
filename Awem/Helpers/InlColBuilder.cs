using System.Collections.Generic;
using System.Linq;
using Omu.AwesomeMvc;

namespace Omu.Awem.Helpers
{
    /// <summary>
    /// Grid Inline edit column builder
    /// </summary>
    public class InlColBuilder : IInlColBuilder
    {
        private readonly Column column;

        private readonly IList<InlElem> elements = new List<InlElem>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="column"></param>
        public InlColBuilder(Column column)
        {
            this.column = column;
        }

        /// <summary>
        /// add inline element
        /// </summary>
        /// <param name="el"></param>
        public void AddInline(InlElem el)
        {
            elements.Add(el);
        }

        /// <summary>
        /// grid column
        /// </summary>
        public Column Column { get { return column; } }

        /// <summary>
        /// inline elements collection
        /// </summary>
        public InlElem[] Elements { get { return elements.ToArray();  } }
    }
}