using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.ReelConcrete
{
    public class FormElementResponse
    {
        public int FormElementResponseId { get; set; }
       
        public int FormElementId { get; set; }
        public string ResponseValue { get; set; } // Bu alan esnek olmalıdır, JSON formatı da kullanılabilir.

       
        public FormElement FormElement { get; set; }
    }
}
