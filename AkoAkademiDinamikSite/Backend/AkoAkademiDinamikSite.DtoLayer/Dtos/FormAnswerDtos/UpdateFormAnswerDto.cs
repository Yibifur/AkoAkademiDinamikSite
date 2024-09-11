using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DtoLayer.Dtos.FormAnswerDtos
{
    public class UpdateFormAnswerDto
    {
        public int FormAnswerId { get; set; }
        public int FormId { get; set; }
        public int FormElementId { get; set; }
        public string Value { get; set; }
        
        
    }
}
