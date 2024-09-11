using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DtoLayer.Dtos.FormAnswerDtos
{
    public class CreateFormAnswerDto
    {

        
        public int FormId { get; set; }
        public int FormElementId { get; set; }
        public string Value { get; set; }
        

        
    }
}
