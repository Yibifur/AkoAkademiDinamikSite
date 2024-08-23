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
        private readonly IFormDal formDal;

        public FormManager(IFormDal formDal)
        {
            this.formDal = formDal;
        }

        public void TDelete(int id)
        {
            formDal.Delete(id);
        }

        public List<Form> TGetAll()
        {
            return formDal.GetAll();    
        }

        public Form TGetById(int id)
        {
            return formDal.GetById(id);   
        }

        public void TInsert(Form entity)
        {
           formDal.Insert(entity);
        }

        public void TUpdate(Form entity)
        {
            formDal.Update(entity);
        }
    }
}
