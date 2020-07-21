using Omu.AwesomeMvc;

namespace Omu.Awem.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInlColBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="el"></param>
        void AddInline(InlElem el);

        /// <summary>
        /// 
        /// </summary>
        Column Column { get; }
    }
}