using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.ReelConcrete
{
    public class Layout
    {
        public int LayoutId { get; set; }
        public string Title { get; set; }
        public string? FooterPartial { get; set; }
        public string? HeaderPartial { get; set; }
        public string? HeadPartial { get; set; }
        public string? ScriptPartial { get; set; }
        public bool IsDefault { get; set; }
    }
}
