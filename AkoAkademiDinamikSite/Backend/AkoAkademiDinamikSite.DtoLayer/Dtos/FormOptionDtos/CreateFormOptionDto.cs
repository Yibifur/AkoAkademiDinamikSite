using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DtoLayer.Dtos.FormOptionDtos
{
    public class CreateFormOptionDto
    {
        public int FormElementId { get; set; }
        //ListeliSeçim
        public string? Name { get; set; }
        public string? Value { get; set; }
        public int? Order { get; set; }
    }
}
