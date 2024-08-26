namespace AkoAkademiDinamikSite.WebUI.Models.Page
{
    public class AddPageViewModel
    {
        
        //public int? ParentPageId { get; set; } // Parent sayfa ile ilişki
        public int? ContentId { get; set; } // İçerik ile ilişki
        public int MenuOrder { get; set; } // Menü sırası
        public bool IsActive { get; set; }
    }
}
