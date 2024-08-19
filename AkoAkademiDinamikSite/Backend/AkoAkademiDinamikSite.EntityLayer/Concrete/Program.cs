using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.Concrete
{
    public class Program
    {
        public int ProgramId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public string IconUrl { get; set; }
        public int AkoSchoolsAndProgramsPartId { get; set; }
        public AkoSchoolsAndProgramsPart AkoSchoolsAndProgramsPart { get; set; }

    }
}
