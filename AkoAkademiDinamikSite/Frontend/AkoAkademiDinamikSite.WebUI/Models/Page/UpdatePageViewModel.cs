namespace AkoAkademiDinamikSite.WebUI.Models.Page
{
    public class UpdatePageViewModel
    {
        public int PageId { get; set; } // Primary Key
        //public int? ParentPageId { get; set; } // Parent sayfa ile ilişki
        public int? ContentId { get; set; } // İçerik ile ilişki
        public int MenuOrder { get; set; } // Menü sırası
        public bool IsActive { get; set; }
    }
}
