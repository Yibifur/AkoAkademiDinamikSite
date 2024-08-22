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
    public class PageManager : IPageService
    {
        private readonly IPageDal PageDal;

        public PageManager(IPageDal PageDal)
        {
            this.PageDal = PageDal;
        }

        public void TDelete(int id)
        {
            PageDal.Delete(id);

        }

        public List<Page> TGetAll()
        {
            return PageDal.GetAll();
        }

        public Page TGetById(int id)
        {
            return PageDal.GetById(id);
        }

        public void TInsert(Page entity)
        {
            PageDal.Insert(entity);
        }

        public void TUpdate(Page entity)
        {
            PageDal.Update(entity);
        }
    }
}
