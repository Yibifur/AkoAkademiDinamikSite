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
    public class MediaManager : IMediaService
    {
        private readonly IMediaDal MediaDal;

        public MediaManager(IMediaDal MediaDal)
        {
            this.MediaDal = MediaDal;
        }

        public void TDelete(int id)
        {
            MediaDal.Delete(id);

        }

        public List<Media> TGetAll()
        {
            return MediaDal.GetAll();
        }

        public Media TGetById(int id)
        {
            return MediaDal.GetById(id);
        }

        public void TInsert(Media entity)
        {
            MediaDal.Insert(entity);
        }

        public void TUpdate(Media entity)
        {
            MediaDal.Update(entity);
        }
    }
}
