using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DtoLayer.Dtos.FormDtos
{
    public class CreateFormDto
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        // Bir Form, birden fazla FormField (form alanı) ile ilişkilidir
        
    }
}
