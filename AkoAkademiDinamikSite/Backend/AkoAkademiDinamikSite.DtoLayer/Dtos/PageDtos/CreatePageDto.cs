using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DtoLayer.Dtos.PageDtos
{
    public class CreatePageDto
    {
       
        //public int? ParentPageId { get; set; } // Parent sayfa ile ilişki
        public int? ContentId { get; set; } // İçerik ile ilişki
        public int MenuOrder { get; set; } // Menü sırası
        public bool IsActive { get; set; }
    }
}
