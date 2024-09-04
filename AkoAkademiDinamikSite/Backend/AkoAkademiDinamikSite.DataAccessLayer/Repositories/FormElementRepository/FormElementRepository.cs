using AkoAkademiDinamikSite.DataAccessLayer.Abstract;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DataAccessLayer.Repositories.FormElementElementRepository
{
    public class FormElementRepository : IFormElementDal
    {
        private readonly AkoContext context;
        public FormElementRepository(AkoContext context)
        {
            this.context = context;
        }
        public void Delete(int id)
        {
            var values = context.FormElements.Find(id);
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), "Entity not found");
            }
            context.FormElements.Remove(values);
            context.SaveChanges();
        }

        public List<FormElement> GetAll()
        {
            var values = context.FormElements.Include(x => x.FormOptions).ToList();
            return values;
        }

        public FormElement GetById(int id)
        {
            var values = context.FormElements.Include(x => x.FormOptions).Where(x => x.FormElementId == id);
            return (FormElement)values;
        }

        public void Insert(FormElement entity)
        {
            context.FormElements.Add(entity);
            context.SaveChanges();
        }

        public void Update(FormElement entity)
        {
            context.FormElements.Update(entity);
            context.SaveChanges();
        }
    }
}
