﻿namespace AkoAkademiDinamikSite.WebUI.Models.Content
{
    public class UpdateContentViewModel
    {
        public int ContentId { get; set; } // Primary Key
        
        public string Title { get; set; } // Sayfa başlığı
        public string Slug { get; set; } // SEO dostu URL
        public string Body { get; set; } // Sayfa içeriği
        public string? Template { get; set; } // Sayfa şablonu
        public DateTime CreatedDate { get; set; } // Oluşturulma tarihi
        public DateTime UpdatedDate { get; set; } // Güncellenme tarihi
        public bool IsPublished { get; set; } // Yayın durumu
    }
}
