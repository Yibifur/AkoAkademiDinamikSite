using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.ReelConcrete
{
    public class FormElement
    {
        public FormElement()
        {
            FormOptions = new List<FormOption>();
        }
        public int FormElementId { get; set; }
        public string Title { get; set; }
        public bool IsRequired { get; set; }
        public int Order { get; set; }
        public string ControlType { get; set; }
        public int FormId { get; set; }
        public  Form Form { get; set; }

        public  List<FormOption>? FormOptions { get; set; }
    }
}
