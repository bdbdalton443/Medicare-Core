using System.Linq;

namespace Omu.Awem.Export
{
    /// <summary>
    /// 
    /// </summary>
    public class GridExpParams
    {
        /// <summary>
        /// visible column ClientFormat or Bind property value
        /// </summary>
        public string[] VisNames { get; set; }

        /// <summary>
        /// get parsed visible names
        /// </summary>
        public string[] GetVisNames()
        {
            var visNames = new string[] { };
            if (VisNames != null)
            {
                visNames = VisNames.Select(o => o.Replace(".", "").Replace("(", "").Replace(")", "")).ToArray();
            }

            return visNames;
        }
    }
}