using System.Linq;
using Omu.AwesomeMvc;

namespace Omu.Awem.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public class PopupButtonCfg
    {
        private readonly PopupButtonTag buttonTag = new PopupButtonTag();

        internal string cssClass;
        internal object htmlAttributes;

        /// <summary>
        /// Set css class for the button
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public PopupButtonCfg CssClass(string o)
        {
            cssClass = o;
            return this;
        }

        /// <summary>
        /// set html attributes
        /// </summary>
        /// <param name="attr">An object that contains the HTML attributes</param>
        /// <returns></returns>
        public PopupButtonCfg HtmlAttributes(object attr)
        {
            htmlAttributes = attr;
            return this;
        }

        internal PopupButtonTag ToTag()
        {
            var dict = AweHelperUtil.GetAttrDictFromObj(htmlAttributes);
            AweHelperUtil.AddClass(dict, cssClass);
            buttonTag.K = dict.Keys.ToArray();
            buttonTag.V = dict.Values.ToArray();

            return buttonTag;
        } 
    }
}