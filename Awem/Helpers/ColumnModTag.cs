using System.Collections.Generic;

namespace Omu.Awem.Helpers
{
    internal class ColumnModTag
    {
        public bool Nohide { get; set; }

        public IList<InlElem> Format { get; set; }

        public int? Autohide { get; set; }

        public string FormatFunc { get; set; }

        public InlElem[][] Fpar { get; set; }

        public string Caption { get; set; }
    }
}