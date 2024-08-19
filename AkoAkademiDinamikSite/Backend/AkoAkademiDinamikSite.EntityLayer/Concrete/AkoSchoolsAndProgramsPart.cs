using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.Concrete
{
    public class AkoSchoolsAndProgramsPart
    {
        public int AkoSchoolsAndProgramsPartId { get; set; }
        public string Title { get; set; }
        public List<Program> Programs { get; set; }
        public List<StatisticService> Services { get; set; }
    }
}
