namespace Omu.Awem.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOddCfg<TCfg>
    {
        /// <summary>
        /// css class to set for the dropdown popup
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        TCfg PopupClass(string o);

        /// <summary>
        /// don't close dropdown on item select
        /// </summary>
        /// <returns></returns>
        TCfg NoSelectClose();

        /// <summary>
        /// set css width of the dropdown 
        /// </summary>
        /// <param name="width">(px or em e.g. 12px)</param>
        /// <returns></returns>
        TCfg MinWidth(string width);

        /// <summary>
        /// set min width in em
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        TCfg MinWidth(int width);

        /// <summary>
        /// set max popup height
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        TCfg PopupMaxHeight(int height);

        /// <summary>
        /// set max popup height
        /// </summary>
        /// <returns></returns>
        TCfg PopupMinWidth(int val);

        /// <summary>
        /// js func to be used for search
        /// </summary>
        /// <param name="func"></param>
        /// <param name="url"></param>
        /// <param name="key">cache key, id used by default</param>
        /// <param name="nocache"></param>
        /// <returns></returns>
        TCfg SearchFunc(string func, string url = null, string key = null, bool nocache = false);

        /// <summary>
        /// Clear cache on load (default true)
        /// </summary>
        /// <param name="clear"></param>
        /// <returns></returns>
        TCfg ClearCacheOnLoad(bool clear);

        /// <summary>
        /// js func used to render dropdown item
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        TCfg ItemFunc(string o);

        /// <summary>
        /// Make dropmenu nodes collapsible
        /// </summary>
        /// <returns></returns>
        TCfg CollapseNodes();
    }
}