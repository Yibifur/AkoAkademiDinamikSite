using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.Concrete
{
    public class NewsAndBlogsPart
    {
        public int NewsAndBlogsPartId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public List<NewsAndBlogType> NewsAndBlogTypes { get; set; }
        public List<NewsAndBlogsEntity> NewsAndBlogsEntities { get; set; }
    }
}
