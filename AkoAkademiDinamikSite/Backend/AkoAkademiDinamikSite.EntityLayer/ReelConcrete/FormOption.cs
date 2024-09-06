using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.ReelConcrete
{
    public class FormOption
    {
        public int FormOptionId { get; set; }
        public int FormElementId { get; set; }
        public  FormElement FormElement { get; set; }
        //ListeliSeçim
        public string?  Name { get; set; }
        public string? Value { get; set; }
        public int? Order { get; set; } 
        public bool? IsSelected { get; set; } // Varsayılan olarak seçili olup olmadığını belirler
        
    }
}
