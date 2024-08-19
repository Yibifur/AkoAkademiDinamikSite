using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.Concrete
{
    public class StatisticService
    {
        public int StatisticServiceId { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public int AkoSchoolsAndProgramsPartId { get; set; }
        public AkoSchoolsAndProgramsPart AkoSchoolsAndProgramsPart { get; set; }
    }
}
