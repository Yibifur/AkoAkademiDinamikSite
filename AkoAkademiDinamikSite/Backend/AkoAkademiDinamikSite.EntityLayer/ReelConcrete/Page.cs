using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.ReelConcrete
{
    public class Page
    {
        public int PageId { get; set; } // Primary Key
       // public int? ParentPageId { get; set; } // Parent sayfa ile ilişki
        public int? ContentId { get; set; } // İçerik ile ilişki
        public int MenuOrder { get; set; } // Menü sırası

        
        public virtual Content Content { get; set; } // İçerik ile ilişki


        public int? FormId { get; set; }
        public Form Form { get; set; }

        /* public virtual Page ParentPage { get; set; } // Parent sayfa ile ilişki

         public virtual List<Page> ChildPages { get; set; } // Alt sayfalar ile ilişki*/
    }
}
