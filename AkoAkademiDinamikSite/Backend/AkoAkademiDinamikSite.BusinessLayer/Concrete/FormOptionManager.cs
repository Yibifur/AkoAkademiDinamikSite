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
    public class FormOptionManager : IFormOptionService
    {
        private readonly IFormOptionDal FormOptionDal;

        public FormOptionManager(IFormOptionDal FormOptionDal)
        {
            this.FormOptionDal = FormOptionDal;
        }

        public void TDelete(int id)
        {
            FormOptionDal.Delete(id);

        }

        public List<FormOption> TGetAll()
        {
            return FormOptionDal.GetAll();
        }

        public FormOption TGetById(int id)
        {
            return FormOptionDal.GetById(id);
        }

        public List<FormOption> TGetFormOptionsByFormElementId(int id)
        {
            return FormOptionDal.GetFormOptionsByFormElementId(id);
        }

        public void TInsert(FormOption entity)
        {
            FormOptionDal.Insert(entity);
        }

        public void TUpdate(FormOption entity)
        {
            FormOptionDal.Update(entity);
        }
    }
}
