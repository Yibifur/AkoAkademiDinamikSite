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
    public class FormAnswerManager : IFormAnswerService
    {
        private readonly IFormAnswerDal FormAnswerDal;

        public FormAnswerManager(IFormAnswerDal FormAnswerDal)
        {
            this.FormAnswerDal = FormAnswerDal;
        }

        public List<FormAnswer> TGetAllFormAnswersByFormElementId(int formElementId)
        {
            return FormAnswerDal.GetAllFormAnswersByFormElementId(formElementId);
        }

        public void TDelete(int id)
        {
            FormAnswerDal.Delete(id);

        }

        public List<FormAnswer> TGetAll()
        {
            return FormAnswerDal.GetAll();
        }

        public FormAnswer TGetById(int id)
        {
            return FormAnswerDal.GetById(id);
        }

        public void TInsert(FormAnswer entity)
        {
            FormAnswerDal.Insert(entity);
        }

        public void TUpdate(FormAnswer entity)
        {
            FormAnswerDal.Update(entity);
        }
    }
}
