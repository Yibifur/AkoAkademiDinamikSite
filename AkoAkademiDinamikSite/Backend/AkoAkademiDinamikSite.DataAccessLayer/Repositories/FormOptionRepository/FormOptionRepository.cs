using AkoAkademiDinamikSite.DataAccessLayer.Abstract;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DataAccessLayer.Repositories.FormOptionRepository
{
    public class FormOptionRepository : IFormOptionDal
    {
        private readonly AkoContext context;
        public FormOptionRepository(AkoContext context)
        {
            this.context = context;
        }
        public void Delete(int id)
        {
            var values = context.FormOptions.Find(id);
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), "Entity not found");
            }
            context.FormOptions.Remove(values);
            context.SaveChanges();
        }

        public List<FormOption> GetAll()
        {
            return context.FormOptions.ToList();
        }

        public FormOption GetById(int id)
        {
            return context.FormOptions.Find(id);
        }

        public List<FormOption> GetFormOptionsByFormElementId(int id)
        {
            return context.FormOptions.Where(x=> x.FormElementId == id).ToList();   
        }

        public void Insert(FormOption entity)
        {
            context.FormOptions.Add(entity);
            context.SaveChanges();
        }

        public void Update(FormOption entity)
        {
            
            context.FormOptions.Update(entity);
            context.SaveChanges();
        }
    }
}
