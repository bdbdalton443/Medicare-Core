namespace Omu.Awem.Helpers
{
    /// <summary>
    /// Otoggle config
    /// </summary>
    public class OtogglCfg
    {
        private readonly OtogglTag tag = new OtogglTag();

        /// <summary>
        /// width
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public OtogglCfg Width(string o)
        {
            tag.Width = o;
            return this;
        }

        /// <summary>
        /// yes text
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public OtogglCfg Yes(string o)
        {
            tag.Yes = o;
            return this;
        }

        /// <summary>
        /// no text
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public OtogglCfg No(string o)
        {
            tag.No = o;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal OtogglTag GetTag()
        {
            return tag;
        }
    }
}