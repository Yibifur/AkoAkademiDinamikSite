using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.ReelConcrete
{
    public class Form
    {
        public Form()
        {
            FormElements = new List<FormElement>();
        }
        public int FormId { get; set; }
        public string Title { get; set; }
        public bool ShowTitle { get; set; }
        public string FormType { get; set; }
        public string Description { get; set; }
        public  List<FormElement>? FormElements { get; set; }


    }
}
