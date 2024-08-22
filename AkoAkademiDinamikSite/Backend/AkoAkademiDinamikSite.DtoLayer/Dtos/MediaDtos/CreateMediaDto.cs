using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DtoLayer.Dtos.MediaDtos
{
    public class CreateMediaDto
    {
        
        public string FilePath { get; set; } // Dosya yolu
        public string FileType { get; set; } // Dosya türü
        public DateTime UploadedDate { get; set; } // Yükleme tarihi
    }
}
