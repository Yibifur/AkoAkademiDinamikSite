using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DtoLayer.Dtos.FormElementDtos
{
    public class UpdateFormElementDto
    {
        public int FormElementId { get; set; }
        public string Title { get; set; }
        public bool IsRequired { get; set; }
        public int Order { get; set; }
        public string ControlType { get; set; }
        public int FormId { get; set; }
        
    }
}
