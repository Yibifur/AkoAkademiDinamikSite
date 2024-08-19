using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.Concrete
{
    public class NewsAndBlogType
    {
        public int NewsAndBlogTypeId { get; set; }
        public string Name { get; set; }
        public List<NewsAndBlogsEntity> newsAndBlogsEntities { get; set; }
    }
}
