using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.ReelConcrete
{
    public class FormResponse
    {
        public int FormResponseId { get; set; }
        public int FormId { get; set; }
        
        public Form Form { get; set; }
        public List<FormElementResponse> FormElementResponses { get; set; }
    }
}
