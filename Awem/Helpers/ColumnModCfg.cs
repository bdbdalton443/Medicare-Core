using System;
using System.Collections.Generic;
using System.Linq;
using Omu.AwesomeMvc;

namespace Omu.Awem.Helpers
{
    /// <summary>
    /// Column mods config
    /// </summary>
    public class ColumnModCfg : IInlColBuilder
    {
        private readonly ColumnModTag tag = new ColumnModTag();

        private readonly Column column;

        internal ColumnModTag GetTag()
        {
            return tag;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="column"></param>
        public ColumnModCfg(Column column)
        {
            this.column = column;
            tag.Format = new List<InlElem>();
        }

        /// <returns></returns>
        /// <summary>
        /// hide column on small screens, or when resizing the browser (should be used with columns selector mod)
        /// </summary>
        /// <param name="order">hide order ( greater number - last to be hidden, 0 - no autohide, lesser number - first to be hidden ) </param>
        /// <returns></returns>
        public ColumnModCfg Autohide(int order = 1)
        {
            tag.Autohide = order;
            return this;
        }

        /// <summary>
        /// disable autohide for this column, use when setting autohide for all columns using grid ColumnsAutohide grid mod
        /// </summary>
        /// <returns></returns>
        public ColumnModCfg NoAutohide()
        {
            tag.Autohide = 0;
            return this;
        }

        /// <summary>
        /// use to disable hiding of the column from the columns selector, it will also disable autohiding
        /// </summary>
        /// <returns></returns>
        public ColumnModCfg Nohide()
        {
            tag.Nohide = true;
            return this;
        }

        /// <summary>
        /// define a js function that will set the inline format of the column; the func will receive the grid row model as the first parameter + additional params
        /// </summary>
        /// <param name="func">js func</param>
        /// <param name="setOptions">set additional options</param>
        /// <returns></returns>
        public ColumnModCfg InlineFunc(string func, Action<InlineFuncOptions> setOptions = null)
        {
            tag.FormatFunc = func;
            var opt = new InlineFuncOptions(column);

            if (setOptions != null)
            {
                setOptions(opt);
                tag.Fpar = opt.AddParams.ToArray();
            }

            return this;
        }

        /// <summary>
        /// column caption used in columns selector
        /// </summary>
        /// <param name="caption"></param>
        /// <returns></returns>
        public ColumnModCfg Caption(string caption)
        {
            tag.Caption = caption;
            return this;
        }

        /// <summary>
        /// adds inline element
        /// </summary>
        /// <param name="el"></param>
        public void AddInline(InlElem el)
        {
            tag.Format.Add(el);
        }

        /// <summary>
        /// 
        /// </summary>
        public Column Column { get { return column; } }
    }
}