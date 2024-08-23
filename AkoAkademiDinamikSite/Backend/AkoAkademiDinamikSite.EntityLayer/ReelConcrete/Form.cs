using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.ReelConcrete
{
    public class Form
    {
        public int FormId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        // Bir Form, birden fazla FormField (form alanı) ile ilişkilidir
        public virtual  List<FormField>? Fields { get; set; }
        

        // Bir Form, bir veya daha fazla Page (sayfa) ile ilişkilidir

    }
}
