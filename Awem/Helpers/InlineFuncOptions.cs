using System;
using System.Collections.Generic;
using Omu.AwesomeMvc;

namespace Omu.Awem.Helpers
{
    /// <summary>
    /// options for grid inline func
    /// </summary>
    public class InlineFuncOptions
    {
        private readonly Column column;
        internal IList<InlElem[]> AddParams { get; set; }

        internal InlineFuncOptions(Column column)
        {
            AddParams = new List<InlElem[]>();
            this.column = column;
        }

        /// <summary>
        /// add parameter
        /// </summary>
        /// <param name="buildInlCol"></param>
        /// <returns></returns>
        public InlineFuncOptions Param(Action<InlColBuilder> buildInlCol)
        {
            var builder = new InlColBuilder(column);
            buildInlCol(builder);
            AddParams.Add(builder.Elements);

            return this;
        }
    }
}