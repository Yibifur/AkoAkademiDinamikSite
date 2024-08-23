using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.ReelConcrete
{
    public class FormSubmission
    {
        public int FormSubmissionId { get; set; }
        public string FormSubmissionName { get; set; }
        public int FormFieldId { get; set; }
        public DateTime SubmittedDate { get; set; }

        
        public FormField Formfield { get; set; }

        
        

        
        
    }
}
