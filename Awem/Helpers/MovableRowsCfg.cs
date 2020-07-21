using System.Collections.Generic;
using System.Linq;
using Omu.AwesomeMvc;

namespace Omu.Awem.Helpers
{
    /// <summary>
    /// Movable rows mod cfg
    /// </summary>
    public class MovableRowsCfg
    {
        private readonly AweInfo awe;
        private readonly IList<string> ids = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="awe"></param>
        public MovableRowsCfg(AweInfo awe)
        {
            this.awe = awe;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gridId"></param>
        /// <param name="ctxid">use context prefix, default true</param>
        /// <returns></returns>
        public MovableRowsCfg DropOn(string gridId, bool ctxid = true)
        {
            if (ctxid)
            {
                gridId = AweUtil.GetContextPrefix(awe.Html) + gridId;
            }

            ids.Add(gridId);

            return this;
        }

        /// <summary>
        /// get grid ids
        /// </summary>
        /// <returns></returns>
        internal string[] GetIds()
        {
            return ids.ToArray();
        }
    }
}