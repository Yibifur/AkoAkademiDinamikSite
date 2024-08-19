using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.Concrete
{
    public class WhoAreWePart
    {
        public int WhoAreWePartId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string MissionDescriptionTitle { get; set; }
        public string MissionDescription { get; set; }
       public string VisionDescriptionTitle { get; set; }
        public string VisionDescription { get; set; }
        
        public string ImageUrl { get; set; }
        

    }
}
