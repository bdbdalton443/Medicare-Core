namespace Omu.Awem.Helpers
{
    /// <summary>
    /// Multiselect config
    /// </summary>
    public class MultiselectCfg : IOddCfg<MultiselectCfg>
    {
        private readonly MultiselectTag tag = new MultiselectTag
        {
            Reorderable = true
        };
        
        /// <summary>
        /// css class to set for the dropdown popup
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public MultiselectCfg PopupClass(string o)
        {
            tag.PopupClass = o;
            return this;
        }

        /// <summary>
        /// make selected items reorderable
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public MultiselectCfg Reorderable(bool o)
        {
            tag.Reorderable = o;
            return this;
        }

        /// <summary>
        /// caption when no item is selected
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public MultiselectCfg Caption(string o)
        {
            tag.Caption = o;
            return this;
        }

        /// <summary>
        /// don't close dropdown on item select
        /// </summary>
        /// <returns></returns>
        public MultiselectCfg NoSelectClose()
        {
            tag.NoSelClose = true;
            return this;
        }

        /// <summary>
        /// set css width of the dropdown 
        /// </summary>
        /// <param name="width">(px or em e.g. 12px)</param>
        /// <returns></returns>
        public MultiselectCfg MinWidth(string width)
        {
            tag.MinWidth = width;
            return this;
        }

        /// <summary>
        /// set min width in em
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public MultiselectCfg MinWidth(int width)
        {
            tag.MinWidth = width + "em";
            return this;
        }

        /// <summary>
        /// set max popup height
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public MultiselectCfg PopupMaxHeight(int height)
        {
            tag.PopupMaxHeight = height;
            return this;
        }

        /// <summary>
        /// set max popup height
        /// </summary>
        /// <returns></returns>
        public MultiselectCfg PopupMinWidth(int val)
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
        public MultiselectCfg SearchFunc(string func, string url = null, string key = null, bool nocache = false)
        {
            tag.Key = key;
            tag.SearchFunc = func;
            tag.Url = url;
            tag.NoCache = nocache; 
            return this;
        }

        /// <summary>
        /// Make dropmenu nodes collapsible
        /// </summary>
        /// <returns></returns>
        public MultiselectCfg CollapseNodes()
        {
            tag.CollapseNodes = true;
            return this;
        }

        /// <summary>
        /// Clear cache on load (default true)
        /// </summary>
        /// <param name="clear"></param>
        /// <returns></returns>
        public MultiselectCfg ClearCacheOnLoad(bool clear)
        {
            tag.ClearCacheOnLoad = !clear;
            return this;
        }

        /// <summary>
        /// js func used to render dropdown item
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public MultiselectCfg ItemFunc(string o)
        {
            tag.ItemFunc = o;
            return this;
        }

        /// <summary>
        /// js func used to render dropdown caption
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public MultiselectCfg CaptionFunc(string o)
        {
            tag.CaptionFunc = o;
            return this;
        }

        /// <summary>
        /// Allow combo values
        /// </summary>
        /// <param name="genKey">generate keys for combo values</param>
        /// <param name="showComboItem">show combo item</param>
        /// <returns></returns>
        public MultiselectCfg Combo(bool genKey = true, bool showComboItem = true)
        {
            tag.Combo = true;
            tag.GenKey = genKey;
            tag.CmbItm = showComboItem;
            return this;
        }

        internal MultiselectTag ToTag()
        {
            return tag;
        }
    }
}