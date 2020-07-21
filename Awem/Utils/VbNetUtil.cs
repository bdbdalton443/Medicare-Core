using Omu.AwesomeMvc;

namespace Omu.Awem.Utils
{
    /// <summary>
    /// utils for VB.NET
    /// </summary>
    public static class VbNetUtil
    {
        /// <summary>
        /// change lookup search and selected action names to SearchItems and SelectedItems to avoid conflict with parameter name
        /// </summary>
        public static void AdjustLookupActionNames()
        {
            Settings.Lookup.SearchAction = "SearchItems";
            Settings.MultiLookup.SelectedAction = "SelectedItems";
        }
    }
}