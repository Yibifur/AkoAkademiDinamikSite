using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DtoLayer.Dtos.ContentDtos
{
    public class CreateContentDto
    {

        public int PageId { get; set; }
        public string Title { get; set; } // Sayfa başlığı
        public string Slug { get; set; } // SEO dostu URL
        public string Body { get; set; } // Sayfa içeriği
        public string? Template { get; set; } // Sayfa şablonu
        public DateTime CreatedDate { get; set; } // Oluşturulma tarihi
        public DateTime UpdatedDate { get; set; } // Güncellenme tarihi
        public bool IsPublished { get; set; } // Yayın durumu
    }
}
