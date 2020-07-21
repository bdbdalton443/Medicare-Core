namespace Omu.Awem.Helpers
{
    /// <summary>
    /// Odropdown config
    /// </summary>
    public class OddCfg : IOddCfg<OddCfg>
    {
        private readonly OdropdownTag tag = new OdropdownTag();

        /// <summary>
        /// css class to set for the dropdown popup
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public OddCfg PopupClass(string o)
        {
            tag.PopupClass = o;
            return this;
        }

        /// <summary>
        /// label text in front of the caption/selected item text
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public OddCfg InLabel(string o)
        {
            tag.InLabel = o;
            return this;
        }

        /// <summary>
        /// caption when no item is selected
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public OddCfg Caption(string o)
        {
            tag.Caption = o;
            return this;
        }

        /// <summary>
        /// autoselect first item on load when no value is matched (change will be triggered)
        /// </summary>
        /// <returns></returns>
        public OddCfg AutoSelectFirst()
        {
            tag.AutoSelectFirst = true;
            return this;
        }

        /// <summary>
        /// set autosearch min items 
        /// </summary>
        /// <param name="minItems"></param>
        /// <returns></returns>
        public OddCfg AutoSearch(int minItems)
        {
            tag.Asmi = minItems;
            return this;
        }

        /// <summary>
        /// turn autosearch on (with min items = 0) or off
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public OddCfg AutoSearch(bool o = true)
        {
            tag.Asmi = o ? 0 : -1;
            return this;
        }

        /// <summary>
        /// don't close dropdown on item select
        /// </summary>
        /// <returns></returns>
        public OddCfg NoSelectClose()
        {
            tag.NoSelClose = true;
            return this;
        }

        /// <summary>
        /// set css width of the dropdown 
        /// </summary>
        /// <param name="width">(px or em e.g. 12px)</param>
        /// <returns></returns>
        public OddCfg MinWidth(string width)
        {
            tag.MinWidth = width;
            return this;
        }

        /// <summary>
        /// set min width in em
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public OddCfg MinWidth(int width)
        {
            tag.MinWidth = width + "em";
            return this;
        }

        /// <summary>
        /// set max popup height
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public OddCfg PopupMaxHeight(int height)
        {
            tag.PopupMaxHeight = height;
            return this;
        }

        /// <summary>
        /// set max popup height
        /// </summary>
        /// <returns></returns>
        public OddCfg PopupMinWidth(int val)
        {
            tag.PopupMinWidth = val;
            return this;
        }

        /// <summary>
        /// js func to be used for search
        /// </summary>
        /// <param name="func"></param>
        /// <param name="url"></param>
        /// <param name="key">cache key, id used by default</param>
        /// <param name="nocache"></param>
        /// <returns></returns>
        public OddCfg SearchFunc(string func, string url = null, string key = null, bool nocache = false)
        {
            tag.Key = key;
            tag.SearchFunc = func;
            tag.Url = url;
            tag.NoCache = nocache;
            return this;
        }

        /// <summary>
        /// Clear cache on load (default true)
        /// </summary>
        /// <param name="clear"></param>
        /// <returns></returns>
        public OddCfg ClearCacheOnLoad(bool clear)
        {
            tag.ClearCacheOnLoad = !clear;
            return this;
        }

        /// <summary>
        /// js func used to render dropdown item
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public OddCfg ItemFunc(string o)
        {
            tag.ItemFunc = o;
            return this;
        }

        /// <summary>
        /// js func used to render dropdown caption
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public OddCfg CaptionFunc(string o)
        {
            tag.CaptionFunc = o;
            return this;
        }

        /// <summary>
        /// Open dropdown on hover
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public OddCfg OpenOnHover(bool o = true)
        {
            tag.OpenOnHover = o;
            return this;
        }

        /// <summary>
        /// Make dropmenu nodes collapsible
        /// </summary>
        /// <returns></returns>
        public OddCfg CollapseNodes()
        {
            tag.CollapseNodes = true;
            return this;
        }

        internal OdropdownTag ToTag()
        {
            return tag;
        }
    }
}