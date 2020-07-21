using System;
using Omu.AwesomeMvc;

namespace Omu.Awem.Helpers
{
    /// <summary>
    /// Lookup mods configuration
    /// </summary>
    public class LookupModCfg
    {
        private readonly PopupTag tag = new PopupTag { Dd = true };

        private readonly AweInfo awe;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookupAwe"></param>
        public LookupModCfg(AweInfo lookupAwe)
        {
            awe = lookupAwe;
        }

        /// <summary>
        /// Close popup when clicking outside of it
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public LookupModCfg OutClickClose(bool o = true)
        {
            tag.Occ = o;
            return this;
        }

        /// <summary>
        /// dropdown popup from opener position
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public LookupModCfg Dropdown(bool o = true)
        {
            tag.Dd = o;
            return this;
        }

        /// <summary>
        /// show header
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public LookupModCfg ShowHeader(bool o = true)
        {
            tag.Sh = o;
            return this;
        }

        internal PopupTag ToTag()
        {
            return tag;
        }
    }
}