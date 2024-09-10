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
    public class FormManager : IFormService
    {
        private readonly IFormDal FormDal;

        public FormManager(IFormDal FormDal)
        {
            this.FormDal = FormDal;
        }

        public void TDelete(int id)
        {
            FormDal.Delete(id);

        }

        public List<Form> TGetAll()
        {
            return FormDal.GetAll();
        }

        public Form TGetById(int id)
        {
            return FormDal.GetById(id);
        }

        public Form TGetDefaultForm()
        {
            return FormDal.GetDefaultForm();
        }

        public void TInsert(Form entity)
        {
            FormDal.Insert(entity);
        }

        public void TUpdate(Form entity)
        {
            FormDal.Update(entity);
        }
    }
}
