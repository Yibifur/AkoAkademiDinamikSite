using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
namespace AkoAkademiDinamikSite.WebUI.Models.Page
{
    public class PageViewModel
    {
        public int PageId { get; set; } // Primary Key
        //public int? ParentPageId { get; set; } // Parent sayfa ile ilişki
        public int? ContentId { get; set; } // İçerik ile ilişki
        public int MenuOrder { get; set; } // Menü sırası
        public bool IsActive { get; set; }

        public virtual  AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Content Content { get; set; } // İçerik ile ilişki

        /* public virtual AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Page ParentPage { get; set; } // Parent sayfa ile ilişki

         public virtual List<AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Page> ChildPages { get; set; } // Alt sayfalar ile ilişki*/
    }
}
