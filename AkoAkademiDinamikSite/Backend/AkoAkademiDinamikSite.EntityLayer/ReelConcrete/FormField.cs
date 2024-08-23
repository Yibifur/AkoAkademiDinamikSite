using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.ReelConcrete
{
    public class FormField
    {
        public int FormFieldId { get; set; }
        public int FormId { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public string FieldAnswer { get; set; }
        public bool IsRequired { get; set; }

        
        public virtual Form Form { get; set; }
    }
}
