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
    public class LayoutManager : ILayoutService
    {
        private readonly ILayoutDal _layoutDal;

        public LayoutManager(ILayoutDal layoutDal)
        {
            _layoutDal = layoutDal;
        }

        public void TDelete(int id)
        {
            _layoutDal.Delete(id);
        }

        public List<Layout> TGetAll()
        {
          return _layoutDal.GetAll();
        }

        public Layout TGetById(int id)
        {
           return  _layoutDal.GetById(id);
        }

        public Layout TGetDefaultlayout()
        {
            return _layoutDal.GetDefaultlayout();
        }

        public void TInsert(Layout entity)
        {
           _layoutDal.Insert(entity);
        }

        public void TUpdate(Layout entity)
        {
          _layoutDal.Update(entity);
        }
    }
}
