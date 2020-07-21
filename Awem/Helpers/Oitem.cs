using System.Collections.Generic;
using System.ComponentModel;
using Omu.AwesomeMvc;

namespace Omu.Awem.Helpers
{
#pragma warning disable 1591
    public class Oitem : KeyContent
    {
        public Oitem()
        {
        }

        public Oitem(object key, string content) : base(key, content)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public string cs { get; set; }

        public string Class { set { cs = value; } }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public int l { get; set; }

        public bool Lazy
        {
            set
            {
               cl = l = AweHelperUtil.ToBool(value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public int cl { get; set; }

        public bool Collapsed { set { cl = AweHelperUtil.ToBool(value); } }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public int nv { get; set; }

        public bool NonVal { set { nv = AweHelperUtil.ToBool(value); } }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public IEnumerable<object> it { get; set; }

        public IEnumerable<object> Items { set { it = value; } }
    }
#pragma warning restore 1591
}