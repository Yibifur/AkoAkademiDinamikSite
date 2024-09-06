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
    public class FormElementManager : IFormElementService
    {
        private readonly IFormElementDal FormElementDal;

        public FormElementManager(IFormElementDal FormElementDal)
        {
            this.FormElementDal = FormElementDal;
        }

        public void TDelete(int id)
        {
            FormElementDal.Delete(id);

        }

        public List<FormElement> TGetAll()
        {
            return FormElementDal.GetAll();
        }

        public List<FormElement> TGetAllFormElementsByFormId(int id)
        {
       return FormElementDal.GetAllFormElementsByFormId(id);
        }

        public FormElement TGetById(int id)
        {
            return FormElementDal.GetById(id);
        }

        public void TInsert(FormElement entity)
        {
            FormElementDal.Insert(entity);
        }

        public void TUpdate(FormElement entity)
        {
            FormElementDal.Update(entity);
        }
    }
    
    
}
