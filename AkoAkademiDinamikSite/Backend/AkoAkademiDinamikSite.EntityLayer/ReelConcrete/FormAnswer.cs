using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.ReelConcrete
{
    public class FormAnswer
    {
        public int FormAnswerId { get; set; }
        public int FormId { get; set; }
        public Form Form { get; set; }
        public int FormElementId { get; set; }
        public FormElement FormElement { get; set; }
        public string Value { get; set; }
        
    }
}
