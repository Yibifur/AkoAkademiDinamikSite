using AkoAkademiDinamikSite.BusinessLayer.Abstract;
using AkoAkademiDinamikSite.DataAccessLayer.Abstract;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.BusinessLayer.Concrete
{
    public class ContentManager:IContentService
    {
        private readonly IContentDal contentDal;

        public ContentManager(IContentDal contentDal)
        {
            this.contentDal = contentDal;
        }

        public void TDelete(int id)
        {
            contentDal.Delete(id);
            
        }

        public List<Content> TGetAll()
        {
            return contentDal.GetAll();
        }

        public Content TGetById(int id)
        {
            return contentDal.GetById(id);    
        }

        public void TInsert(Content entity)
        {
            contentDal.Insert(entity);
        }

        public void TUpdate(Content entity)
        {
            contentDal.Update(entity);
        }
    }
}
