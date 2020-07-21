namespace Omu.Awem.Helpers
{
    /// <summary>
    /// Combobox config
    /// </summary>
    public class ComboboxCfg : IOddCfg<ComboboxCfg>
    {
        private readonly ComboboxTag tag = new ComboboxTag();

        /// <summary>
        /// select text on focus
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public ComboboxCfg SelectOnFocus(bool o = true)
        {
            tag.Sof = o;
            return this;
        }

        /// <summary>
        /// css class to set for the dropdown popup
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public ComboboxCfg PopupClass(string o)
        {
            tag.PopupClass = o;
            return this;
        }

        /// <summary>
        /// Show combo item (default true)
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public ComboboxCfg ShowComboItem(bool o)
        {
            tag.CmbItm = o;
            return this;
        }

        /// <summary>
        /// close dropdown when combo search text is empty
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public ComboboxCfg CloseOnEmptyQuery(bool o = true)
        {
            tag.ClsEq = o;
            return this;
        }

        /// <summary>
        /// use content value instead of key
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public ComboboxCfg UseConVal(bool o = true)
        {
            tag.UseConVal = o;
            return this;
        }

        /// <summary>
        /// caption when no item is selected
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public ComboboxCfg Caption(string o)
        {
            tag.Caption = o;
            return this;
        }

        /// <summary>
        /// autoselect first item on load when no value is matched (change will be triggered)
        /// </summary>
        /// <returns></returns>
        public ComboboxCfg AutoSelectFirst()
        {
            tag.AutoSelectFirst = true;
            return this;
        }

        /// <summary>
        /// don't close dropdown on item select
        /// </summary>
        /// <returns></returns>
        public ComboboxCfg NoSelectClose()
        {
            tag.NoSelClose = true;
            return this;
        }

        /// <summary>
        /// set css width of the dropdown 
        /// </summary>
        /// <param name="width">(px or em e.g. 12px)</param>
        /// <returns></returns>
        public ComboboxCfg MinWidth(string width)
        {
            tag.MinWidth = width;
            return this;
        }

        /// <summary>
        /// set min width in em
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public ComboboxCfg MinWidth(int width)
        {
            tag.MinWidth = width + "em";
            return this;
        }

        /// <summary>
        /// set max popup height
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public ComboboxCfg PopupMaxHeight(int height)
        {
            tag.PopupMaxHeight = height;
            return this;
        }

        /// <summary>
        /// set max popup height
        /// </summary>
        /// <returns></returns>
        public ComboboxCfg PopupMinWidth(int val)
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
        public ComboboxCfg SearchFunc(string func, string url = null, string key = null, bool nocache = false)
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
        public ComboboxCfg CollapseNodes()
        {
            tag.CollapseNodes = true;
            return this;
        }

        /// <summary>
        /// Clear cache on load (default true)
        /// </summary>
        /// <param name="clear"></param>
        /// <returns></returns>
        public ComboboxCfg ClearCacheOnLoad(bool clear)
        {
            tag.ClearCacheOnLoad = clear;
            return this;
        }

        /// <summary>
        /// js func used to render dropdown item
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public ComboboxCfg ItemFunc(string o)
        {
            tag.ItemFunc = o;
            return this;
        }

        internal ComboboxTag ToTag()
        {
            return tag;
        }
    }
}