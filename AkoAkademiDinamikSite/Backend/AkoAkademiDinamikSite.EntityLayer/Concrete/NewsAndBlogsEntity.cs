using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.Concrete
{
    public class NewsAndBlogsEntity
    {
        public int NewsAndBlogsEntityId { get; set; }
        public string ImageUrl { get; set; }
        public int NewsAndBlogTypeId { get; set; }
        public NewsAndBlogType NewsAndBlogType { get; set; }
    }
}
